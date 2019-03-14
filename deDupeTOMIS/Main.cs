﻿using System;
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

            cv::VideoCapture capDev = new cv::VideoCapture(0);
            cv::Window vidPreview = new cv::Window("Video Preview");
            cv::Mat imgRaw = new cv::Mat();

            //using (VideoCapture capDev = new VideoCapture(0))
            //using (Window vidPreview = new Window("Video Preview"))
            //using (Mat imgRaw = new Mat())
            {
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
            }
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

        private void IdentifyImage(object sender, EventArgs e)
        {
            imgProcessed.Image = FrState.imgWorking.ToBitmap();
            imgProcessed.Update();

            cv::Mat imgProc = FrState.imgWorking.Clone();
            cv::Mat imgFinal = FrState.imgWorking.Clone();

            String haarLocation = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\..\\..\\haarCascades\\";

            cv::CascadeClassifier faceC = new cv::CascadeClassifier(haarLocation + "haarcascade_frontalface_alt.xml");
            cv::CascadeClassifier eyeL = new cv::CascadeClassifier(haarLocation + "haarcascade_lefteye_2splits.xml");
            cv::CascadeClassifier eyeR = new cv::CascadeClassifier(haarLocation + "haarcascade_righteye_2splits.xml");
            cv::CascadeClassifier eyes = new cv::CascadeClassifier(haarLocation + "haarcascade_eye.xml");

            cv::Rect[] faces;
            cv::Rect[] eyeLeft;
            cv::Rect[] eyeRight;
            cv::Rect[] eyeBoth;

            float imgArea = imgProc.Rows * imgProc.Cols;
            float faceWidth = (float)(System.Math.Sqrt(imgArea / C.phi));
            float faceHeight = imgArea / faceWidth;

            int detectWidth = (int)System.Math.Round(faceWidth * 0.125);
            int detectHeight = (int)System.Math.Round(faceHeight * 0.125);
            int detectEyeHeight = (int)System.Math.Round(detectHeight * 0.125);
            int detectEyeWidth = (int)System.Math.Round(detectEyeHeight * C.phi);

            faces = faceC.DetectMultiScale(imgProc,1.1, 2, cv::HaarDetectionType.DoCannyPruning,new OpenCvSharp.Size(detectEyeWidth,detectEyeHeight));
            eyeLeft = eyeL.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));
            eyeRight = eyeR.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));
            eyeBoth = eyes.DetectMultiScale(imgProc, 1.1, 2, cv::HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));

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

                // check L eye detector
                int nLeyes = 0;
                int nReyes = 0;

                for (int i = 0; i < eyeLeft.Length; i++)
                {
                    // figure the center of the eye guess
                    OpenCvSharp.Point ctrEye = new OpenCvSharp.Point(eyeLeft[i].X + (eyeLeft[i].Width / 2), eyeLeft[i].Y + (eyeLeft[i].Height / 2));
                    if (faceI.Contains(ctrEye))
                    {   // if ctr eye point is in detected face
                        if (ctrEye.X < ctr.X)
                        {   // and point is left of the midline
                            if (ctrEye.Y < ctr.Y)
                            {   // and point is above center of face
                                nLeyes++;
                                eyeLctrs[nLeyes] = ctrEye; // this is a good left eye guess
                            }
                        }
                    }
                }

                for (int i = 0; i < eyeRight.Length; i++)
                {
                    // figure the center of the eye guess
                    OpenCvSharp.Point ctrEye = new OpenCvSharp.Point(eyeRight[i].X + (eyeRight[i].Width / 2), eyeRight[i].Y + (eyeRight[i].Height / 2));
                    if (faceI.Contains(ctrEye))
                    {   // if ctr eye point is in detected face
                        if (ctrEye.X < ctr.X)
                        {   // and point is left of the midline
                            if (ctrEye.Y < ctr.Y)
                            {   // and point is above center of face
                                nReyes++;
                                eyeRctrs[nReyes] = ctrEye; // this is a good left eye guess
                            }
                        }
                    }
                }
                OpenCvSharp.Scalar ScWhite = new OpenCvSharp.Scalar(255, 255, 255);
                OpenCvSharp.Scalar ScBlack = new OpenCvSharp.Scalar(0, 0, 0);
                OpenCvSharp.Scalar ScRed = new OpenCvSharp.Scalar(0, 0, 255);
                OpenCvSharp.Scalar ScGreen = new OpenCvSharp.Scalar(0, 255, 0);
                OpenCvSharp.Scalar ScBlue = new OpenCvSharp.Scalar(255, 0, 0);

                float eWidth = faceI.Width;
                float eHeight = faceI.Width * C.phi;

                OpenCvSharp.Size2f eSize = new OpenCvSharp.Size2f((float)eWidth, (float)eHeight);
                OpenCvSharp.Size eSizeRect = new OpenCvSharp.Size((int)eWidth, (int)eHeight);

                float angle = (float)(System.Math.Atan2(eyeRctrs[0].Y - eyeLctrs[0].Y, eyeRctrs[0].X - eyeLctrs[0].X)*180 / System.Math.PI);
                OpenCvSharp.RotatedRect faceE = new OpenCvSharp.RotatedRect(ctr,eSize,angle);
                OpenCvSharp.Rect faceRect = new OpenCvSharp.Rect(ctr.X-(eSizeRect.Width/2), ctr.Y-(eSizeRect.Height/2), eSizeRect.Width, eSizeRect.Height);

                Random rnd = new Random();
                int endLp = rnd.Next(1,3);
                for (int j = 0; j < endLp; j++)
                {
                    for (int i = 0; i < eyeLeft.Length; i++)
                    {
                        imgProcessed.Image = FrState.imgWorking.ToBitmap();
                        imgProcessed.Update();
                        imgProc.Rectangle(eyeLeft[i], ScRed, 8);
                        imgProcessed.Image = imgProc.ToBitmap();
                        imgProcessed.Update();
                        imgProc = imgFinal.Clone();
                        System.Threading.Thread.Sleep(rnd.Next(50, 250));
                    }

                    for (int i = 0; i < eyeRight.Length; i++)
                    {
                        imgProcessed.Image = FrState.imgWorking.ToBitmap();
                        imgProcessed.Update();
                        imgProc.Rectangle(eyeRight[i], ScGreen, 8);
                        imgProcessed.Image = imgProc.ToBitmap();
                        imgProcessed.Update();
                        imgProc = imgFinal.Clone();
                        System.Threading.Thread.Sleep(rnd.Next(50,250));
                    }

                    for (int i = 0; i < eyeBoth.Length; i++)
                    {
                        imgProc.Rectangle(eyeBoth[i], ScBlue, 8);
                        imgProcessed.Image = FrState.imgWorking.ToBitmap();
                        imgProcessed.Update();
                        imgProc.Rectangle(eyeBoth[i], ScBlue, 8);
                        imgProcessed.Image = imgProc.ToBitmap();
                        imgProcessed.Update();
                        imgProc = imgFinal.Clone();
                        System.Threading.Thread.Sleep(rnd.Next(50,250));
                    }
                }
                imgProc.Circle(ctr, 1, ScBlack, 8);
                imgProc.Ellipse(faceE, ScWhite, 8);
                imgProcessed.Image = imgProc.ToBitmap();

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
            String sql = "select top (500) a.* " +
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
            String sql = "select top (500) a.* " +
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
            string sqlCount = "select top (500) count(*) from prod.ADL800";
            String sql = "select top (500) a.* " +
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
            nRecs = 500;
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
