using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cv = OpenCvSharp;
using OpenCvSharp.Extensions;
using T = Tesseract;


namespace deDupeTOMIS
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FrState.TemplateTrained = false;
            Update_Status();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            findImageProgressBar.Enabled = false;
            Update_Status();
        }

        public bool TemplateDbTrained()
        {
            FrState.TemplateTrained = true;
            return (FrState.TemplateTrained);
        }

        public void Update_Status()
        {
            if (FrState.TemplateTrained)
            {
                StatusFlagTemplateDb.Text = "TRAINED";
                StatusFlagTemplateDb.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                StatusFlagTemplateDb.Text = "UNTRAINED";
                StatusFlagTemplateDb.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void BtnWebCamStart_Click(object sender, EventArgs e)
        {
            bool done = false;
            this.Enabled = false;
            this.Refresh();

            cv::VideoCapture capDev = new cv::VideoCapture(0);
            cv::Window vidPreview = new cv::Window("Video Preview");
            cv::Mat imgRaw = new cv::Mat();

            while (!done)
            {
                capDev.Read(imgRaw); // same as cvQueryFrame
                if (!imgRaw.Empty())
                {
                    vidPreview.ShowImage(imgRaw);
                    switch (cv::Cv2.WaitKey(100))
                    {
                        case 13:
                            FrState.imgWorking = imgRaw.Clone();
                            imgOriginal.Image = FrState.imgWorking.ToBitmap();
                            done = true;
                            break;
                        case 27:
                            done = true;
                            break;
                    }
                }
            }
            vidPreview.Close();
            vidPreview.Dispose();
            imgRaw.Dispose();
            capDev.Dispose();
            this.Enabled = true;
            this.Refresh();
        }

        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofDialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\..\\..\\..\\inputImages\\",
                Filter = "jpeg (*.jpg)|*.jpg|png (*.png)|*.png|All Files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                // put file image into win bitmap
                Bitmap imgBmp = (Bitmap)Image.FromFile(ofDialog.FileName);
                // colnvert to MAT format and put into global working image
                FrState.imgWorking = BitmapConverter.ToMat(imgBmp);
                // display the original image in the app
                imgOriginal.Image = imgBmp;
            }
        }

        private void PreProcessImage()
        {
            // windows bitmap to MAT
            cv::Mat imgProc = BitmapConverter.ToMat((Bitmap)imgOriginal.Image);

            // if input image low res convert to higher res
            ////////////////////////////

            // load classifiers
            String haarLocation = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\..\\..\\haarCascades\\";
            cv::CascadeClassifier faceC = new cv::CascadeClassifier(haarLocation + "haarcascade_frontalface_alt.xml");
            cv::CascadeClassifier eyeL = new cv::CascadeClassifier(haarLocation + "haarcascade_lefteye_2splits.xml");
            cv::CascadeClassifier eyeR = new cv::CascadeClassifier(haarLocation + "haarcascade_righteye_2splits.xml");

            cv::Rect[] faces;
            cv::Rect[] eyeLeft;
            cv::Rect[] eyeRight;

            faces = faceC.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning);
            eyeLeft = eyeL.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning);
            eyeRight = eyeR.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning);

            // find biggest detected face
            int faceIdx = 0;
            if (faces.Length >= 1)
            {
                // Largest Face Found
                long size = 0;
                long max = 0;
                for (int i = 0; i < faces.Length; i++)
                {
                    size = faces[i].Height * faces[i].Width;
                    if (size > max)
                    {
                        max = size;
                        faceIdx = i;
                    }
                }
                //Find Center of detected Face
                cv::Rect faceI = faces[faceIdx];
                OpenCvSharp.Point ctr = new OpenCvSharp.Point(faceI.X + (faceI.Width / 2), faceI.Y + (faceI.Height / 2));

                OpenCvSharp.Point[] eyeLctrs = new OpenCvSharp.Point[eyeLeft.Length];
                OpenCvSharp.Point[] eyeRctrs = new OpenCvSharp.Point[eyeRight.Length];

                OpenCvSharp.Point lECtr = new OpenCvSharp.Point();
                OpenCvSharp.Point rECtr = new OpenCvSharp.Point();

                // compute average eye center left and right
                if (eyeLeft.Length > 1)
                {
                    int xA = 0;
                    int yA = 0;
                    for (int i = 0; i < eyeLeft.Length; i++)
                    {
                        // figure the center of the eye guess
                        xA = xA + (eyeLeft[i].X + (eyeLeft[i].Width / 2));
                        yA = yA + (eyeLeft[i].Y + (eyeLeft[i].Height / 2));
                    }
                    lECtr.X = xA / eyeLeft.Length;
                    lECtr.Y = yA / eyeLeft.Length;
                } else
                {
                    lECtr.X = eyeLeft[0].X + (eyeLeft[0].Width / 2);
                    lECtr.Y = eyeLeft[0].Y + (eyeLeft[0].Height / 2);
                }
                // check R eye detector
                if (eyeRight.Length > 1)
                {
                    int xA = 0;
                    int yA = 0;
                    for (int i = 0; i < eyeRight.Length; i++)
                    {
                        // figure the center of the eye guess
                        xA = xA + (eyeRight[i].X + (eyeRight[i].Width / 2));
                        yA = yA + (eyeRight[i].Y + (eyeRight[i].Height / 2));
                    }
                    rECtr.X = xA / eyeRight.Length;
                    rECtr.Y = yA / eyeRight.Length;
                }
                else
                {
                    rECtr.X = eyeRight[0].X + (eyeRight[0].Width / 2);
                    rECtr.Y = eyeRight[0].Y + (eyeRight[0].Height / 2);
                }

                OpenCvSharp.Scalar ScBlack = new OpenCvSharp.Scalar(0, 0, 0);

                float eWidth = faceI.Width;
                float eHeight = faceI.Width * C.phi;

                OpenCvSharp.Size2f eSize = new OpenCvSharp.Size2f((float)eWidth, (float)eHeight);
                OpenCvSharp.Size eSizeRect = new OpenCvSharp.Size((int)eWidth, (int)eHeight);

                float angle = (float)(System.Math.Atan2(rECtr.Y - lECtr.Y, rECtr.X - lECtr.X)*180 / System.Math.PI);
                OpenCvSharp.RotatedRect faceE = new OpenCvSharp.RotatedRect(ctr,eSize,angle);
                OpenCvSharp.Rect faceRect = new OpenCvSharp.Rect(ctr.X-(eSizeRect.Width/2), ctr.Y-(eSizeRect.Height/2), eSizeRect.Width, eSizeRect.Height);

                // draw processed ellipse
                imgProc.Ellipse(faceE, ScBlack, 2);
                imgProc.Circle(ctr, 2, ScBlack, 1);
                imgProc.Circle(rECtr, 2, ScBlack, 1);
                imgProc.Circle(lECtr, 2, ScBlack, 1);

                cv::Mat imgResize = imgProc.Clone(faceRect);
                OpenCvSharp.Size newSize = new OpenCvSharp.Size(960,1440);
                imgResize.Resize(newSize);
                imgProcessed.Image = imgResize.ToBitmap();
                
                imgProcessed.Update();
            }
            else
            {
                MessageBox.Show("No Face Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnTrainTemplates_Click(object sender, EventArgs e)
        {
            DateTime timeStart, timeEnd;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            // set connection parameters
            String connectionString = @"Data Source=ag03ndcwb00053;Initial Catalog=FrTempSrcCopy;Integrated Security=True";
            String sql = "select top (100) a.* " +
            "from prod.ADL800 a " +
                "join ( select ID_TOMIS, count(*) as countDup " +
                    "from prod.ADL800 " +
                    "group by ID_TOMIS) b " +
                "on a.ID_TOMIS = b.ID_TOMIS " +
                "order by countDup DESC, ID_TOMIS ASC, DTE_IMG_TKEN ASC;";
            //open db connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                timeStart = DateTime.Now;
                timeStartDisplay.Text = timeStart.ToLongTimeString();
                timeStartDisplay.Refresh();
                while (dataReader.Read())
                {
                    Image img;
                    tomisID.Text = dataReader["ID_TOMIS"].ToString();
                    tomisID.Refresh();
                    img = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])dataReader["IMG_FCE"]));
                    imgOriginal.Image = img;
                    imgOriginal.Refresh();
                    PreProcessImage();
                }
                timeEnd = DateTime.Now;
                timeEndDisplay.Text = timeEnd.ToLongTimeString();
                TimeSpan timeElapsed = timeEnd - timeStart;
                timeElapsedDisplay.Text = timeElapsed.ToString(@"hh\:mm\:ss\.ff");
            }
            cnn.Close();

            FrState.TemplateTrained = true;
            Update_Status();
        }

        private void BtnDedupDb_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            // set connection parameters
            String connectionString = @"Data Source=ag03ndcwb00053;Initial Catalog=FrTempSrcCopy;Integrated Security=True";
            String sql = "select top (100) a.* " +
            "from prod.ADL800 a " +
                "join ( select ID_TOMIS, count(*) as countDup " +
                    "from prod.ADL800 " +
                    "group by ID_TOMIS) b " +
                "on a.ID_TOMIS = b.ID_TOMIS " +
                "order by countDup DESC, ID_TOMIS ASC, DTE_IMG_TKEN ASC;";
            //open db connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Image img;
                    tomisID.Text = dataReader["ID_TOMIS"].ToString();
                    tomisID.Refresh();
                    img = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])dataReader["IMG_FCE"]));
                    imgOriginal.Image = img;
                    imgOriginal.Refresh();
                }
            }
            cnn.Close();
        }

        private void BtnFindImage_Click(object sender, EventArgs e)
        {
            findImageProgressBar.Enabled = true;
            findImageProgressBar.Minimum = 0;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            // set connection parameters
            String connectionString = @"Data Source=ag03ndcwb00053;Initial Catalog=FrTempSrcCopy;Integrated Security=True";
            string sqlCount = "select top (100) count(*) from prod.ADL800";
            String sql = "select top (100) a.* " +
            "from prod.ADL800 a " +
                "join ( select ID_TOMIS, count(*) as countDup " +
                    "from prod.ADL800 " +
                    "group by ID_TOMIS) b " +
                "on a.ID_TOMIS = b.ID_TOMIS " +
                "order by countDup DESC, ID_TOMIS ASC, DTE_IMG_TKEN ASC;";
            //open db connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            command = new SqlCommand(sqlCount, cnn);
            int nRecs = (int)command.ExecuteScalar();
            nRecs = 100;
            textRecogProg.Text = string.Format("Searching {0} Records :", nRecs);
            statusBarMain.Refresh();

            int iCount = 0;

            command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                findImageProgressBar.Maximum = nRecs;
                while (dataReader.Read())
                {
                    iCount++;
                    findImageProgressBar.Value = iCount;
                    Image img;
                    tomisID.Text = dataReader["ID_TOMIS"].ToString();
                    tomisID.Refresh();
                    img = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])dataReader["IMG_FCE"]));
                    imgProcessed.Image = img;
                    imgProcessed.Refresh();
                }
            }
            cnn.Close();
        }
    }
}
