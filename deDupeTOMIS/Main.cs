using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace deDupeTOMIS
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FrState.ippConnected = false;
            FrState.templateDbConnected = false;
            FrState.tomisDbConnected = false;
            Update_Status();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            Update_Status();
        }

        public void Update_Status()
        {
            if (FrState.ippConnected)
            {
                statusFlagIPP.Text = "CONNECTED";
                statusFlagIPP.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statusFlagIPP.Text = "DISCONNECTED";
                statusFlagIPP.ForeColor = System.Drawing.Color.Red;
            }

            if (FrState.templateDbConnected)
            {
                statusFlagTemplateDb.Text = "CONNECTED";
                statusFlagTemplateDb.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statusFlagTemplateDb.Text = "DISCONNECTED";
                statusFlagTemplateDb.ForeColor = System.Drawing.Color.Red;
            }

            if (FrState.tomisDbConnected)
            {
                statusFlagTomisDb.Text = "CONNECTED";
                statusFlagTomisDb.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                statusFlagTomisDb.Text = "DISCONNECTED";
                statusFlagTomisDb.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnWebCamStart_Click(object sender, EventArgs e)
        {
            bool done = false;
            this.Enabled = false;

            VideoCapture capDev = new VideoCapture(0);
            Window vidPreview = new Window("Video Preview");
            Mat imgRaw = new Mat();

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
                        switch (Cv2.WaitKey(100))
                        {
                            case 13:
                                FrState.imgWorking = imgRaw.Clone();
                                imgOriginal.Image = FrState.imgWorking.ToBitmap();
                                btnIdentifyImage.Enabled = true;
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

        private void btnImageFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath)+"\\..\\..\\..\\inputImages\\";
            ofDialog.Filter = "jpeg (*.jpg)|*.jpg|png (*.png)|*.png|All Files (*.*)|*.*";
            ofDialog.FilterIndex = 1;
            ofDialog.RestoreDirectory = false;


            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                // put file image into win bitmap
                Bitmap imgBmp = (Bitmap)Image.FromFile(ofDialog.FileName);
                // colnvert to MAT format and put into global working image
                FrState.imgWorking = BitmapConverter.ToMat(imgBmp);
                // display the original image in the app
                imgOriginal.Image = imgBmp;
                // allow sending of the image to processing
                btnIdentifyImage.Enabled = true;
            }
        }

        private void imgOriginal_Click(object sender, EventArgs e)
        {
            if (btnIdentifyImage.Enabled)
            {
                btnIdentifyImage_Click(sender, e);
            }
        }

        private void btnIdentifyImage_Click(object sender, EventArgs e)
        {
            imgProcessed.Image = FrState.imgWorking.ToBitmap();
            imgProcessed.Update();

            Mat imgProc = FrState.imgWorking.Clone();
            Mat imgFinal = FrState.imgWorking.Clone();

            String haarLocation = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\..\\..\\haarCascades\\";

            CascadeClassifier faceC = new CascadeClassifier(haarLocation + "haarcascade_frontalface_alt.xml");
            CascadeClassifier eyeL = new CascadeClassifier(haarLocation + "haarcascade_lefteye_2splits.xml");
            CascadeClassifier eyeR = new CascadeClassifier(haarLocation + "haarcascade_righteye_2splits.xml");
            CascadeClassifier eyes = new CascadeClassifier(haarLocation + "haarcascade_eye.xml");

            Rect[] faces;
            Rect[] eyeLeft;
            Rect[] eyeRight;
            Rect[] eyeBoth;

            float imgArea = imgProc.Rows * imgProc.Cols;
            float faceWidth = (float)(System.Math.Sqrt(imgArea / C.phi));
            float faceHeight = imgArea / faceWidth;

            int detectWidth = (int)System.Math.Round(faceWidth * 0.125);
            int detectHeight = (int)System.Math.Round(faceHeight * 0.125);
            int detectEyeHeight = (int)System.Math.Round(detectHeight * 0.125);
            int detectEyeWidth = (int)System.Math.Round(detectEyeHeight * C.phi);

            faces = faceC.DetectMultiScale(imgProc,1.1, 2, HaarDetectionType.DoCannyPruning,new OpenCvSharp.Size(detectEyeWidth,detectEyeHeight));
            eyeLeft = eyeL.DetectMultiScale(imgProc, 1.1, 2, HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));
            eyeRight = eyeR.DetectMultiScale(imgProc, 1.1, 2, HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));
            eyeBoth = eyes.DetectMultiScale(imgProc, 1.1, 2, HaarDetectionType.DoCannyPruning, new OpenCvSharp.Size(detectEyeWidth, detectEyeHeight));

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
                Rect faceI = faces[faceIdx];
                OpenCvSharp.Point ctr = new OpenCvSharp.Point(faceI.X + (faceI.Width / 2), faceI.Y + (faceI.Height / 2));
                //System.Diagnostics.Debug.Print(ctr.ToString());

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

                float angle = (float)(System.Math.Atan2(eyeRctrs[0].Y - eyeLctrs[0].Y, eyeRctrs[0].X - eyeLctrs[0].X)*180 / System.Math.PI);
                OpenCvSharp.RotatedRect faceE = new OpenCvSharp.RotatedRect(ctr,eSize,angle);

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
            }
            else
            {
                MessageBox.Show("No Face Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
