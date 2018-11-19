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

            Window winVideo = new Window("Camera");
            Mat imgRaw = new Mat();
            {
                while (!done)
                {
                    capDev.Read(imgRaw); // same as cvQueryFrame
                    if (!imgRaw.Empty())
                    {
                        winVideo.ShowImage(imgRaw);
                        switch (Cv2.WaitKey(10))
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
                winVideo.Close();
                winVideo.Dispose();
                imgRaw.Dispose();
                this.Enabled = true;
            };
            capDev.Release();
        }

        private void btnImageFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"..\\..\\..\\..\\inputImages\\";
            ofDialog.Filter = "jpeg (*.jpg)|*.jpg|png (*.png)|*.png|All Files (*.*)|*.*";
            ofDialog.FilterIndex = 1;
            ofDialog.RestoreDirectory = false;


            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap imgBmp = (Bitmap)Image.FromFile(ofDialog.FileName);
                FrState.imgWorking = BitmapConverter.ToMat(imgBmp);
                imgOriginal.Image = imgBmp;
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
            Window sendingImage = new Window("Sending This Image");
            sendingImage.ShowImage(FrState.imgWorking);
            Cv2.WaitKey(30);
            sendingImage.Dispose();
        }
    }
}
