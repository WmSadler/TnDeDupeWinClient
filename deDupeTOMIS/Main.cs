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
                            imgOriginal.Image = imgRaw.ToBitmap();
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
            PreProcessImage("WebCam");
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
                // display the original image in the app
                imgOriginal.Image = imgBmp;
                PreProcessImage(ofDialog.FileName);
            }
        }

        private void PreProcessImage(String tId)
        {
            // preprocess image to make it ready for FR
            // windows bitmap to MAT for processing
            cv::Mat imgProc = BitmapConverter.ToMat((Bitmap)imgOriginal.Image);

            // load classifiers
            String haarLocation = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\haar\\";
            cv::CascadeClassifier faceC = new cv::CascadeClassifier(haarLocation + "haarcascade_frontalface_alt.xml");

            cv::Rect[] faces;

            faces = faceC.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning);

            // find biggest detected face
            int faceIdx = 0;
            if (faces.Length >= 1)
            {
                // Largest Face Found
                long size = 0;          long max = 0;
                for (int i = 0; i < faces.Length; i++)
                {
                    size = faces[i].Height * faces[i].Width;
                    if (size > max)
                    {
                        max = size;
                        faceIdx = i;
                    }
                }

                cv::Mat imgResize = imgProc.Clone(faces[faceIdx]);
                OpenCvSharp.Size newSize = new OpenCvSharp.Size(1280,1280);
                imgResize.Resize(newSize);
                imgProcessed.Image = imgResize.ToBitmap();
                imgProcessed.Update();
                //imgOriginal.Refresh();
            }
            else
            {
                Console.WriteLine(String.Format("No Face Found TomisID {0}", tId));
                //MessageBox.Show("No Face Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //String sql = "select top (100) a.* " +
            String sql = "select a.* " + 
                "from prod.ADL800 a " +
                "join ( select ID_TOMIS, count(*) as countDup " +
                    "from prod.ADL800 " +
                    "where ID_TOMIS='00338079' " +
                    "group by ID_TOMIS) b " +
                "on a.ID_TOMIS = b.ID_TOMIS " +
                "order by countDup DESC, ID_TOMIS ASC, DTE_IMG_TKEN ASC;";
            //open db connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            command = new SqlCommand(sql, cnn);
                        SqlDataReader dataReader = command.ExecuteReader();
            //SqlDataReader dataReader = command.ExecuteReaderAsync();
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
                    PreProcessImage(tomisID.Text);
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
            //String sql = "select top (100) a.* " +
            String sql = "select a.* " + 
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
            //string sqlCount = "select top (100) count(*) from prod.ADL800";
            string sqlCount = "select count(*) from prod.ADL800";
            //String sql = "select top (100) a.* " +
            String sql = "select a.* " + 
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
            //nRecs = 100;
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

        private void BtnImpersonate_Click(object sender, EventArgs e)
        {/*
            Whoami Uid = inpUid.Text;
            DbCreds.Pwd = inpPw.Text;
            if (DbCreds.Impersonate())
            {
                MessageBox.Show("Done");
            } else
            {
                MessageBox.Show("Failed");
            }*/
        }
    }
}