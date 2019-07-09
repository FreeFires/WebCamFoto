using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamFoto
{
    public partial class FormWebCam : Form
    {
        public FormWebCam()
        {
            InitializeComponent();
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        Bitmap bitmap;

        private void FormWebCam_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                cmbSelectCam.Items.Add(VideoCaptureDevice.Name);
            }
            cmbSelectCam.SelectedItem = 0;
        }

        private void BtmStartCam_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[cmbSelectCam.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NameFrame);
            cam.Start();
        }

        void cam_NameFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            imgWebCam.Image = bitmap;
        }

        private void ImgWebCam_Click(object sender, EventArgs e)
        {
            imgWebCam.Image = bitmap;
        }

        /*private void BtnSave_Click(object sender, EventArgs e)
        {
            if (imgForSave != null)
            {
                Bitmap imgSave = (Bitmap)bitmap.Clone();
                String ActiveDir = AppDomain.CurrentDomain.BaseDirectory;
                String filepath = System.IO.Path.Combine(ActiveDir, @"D://!Photo/");
                if (!System.IO.Directory.Exists(filepath))
                {
                    System.IO.DirectoryInfo directory = System.IO.Directory.CreateDirectory(@"D://!Photo");
                    String fileName = System.IO.Path.Combine(filepath, tbFIO.Text + @".jpeg");
                    if (!System.IO.File.Exists(fileName))
                    {
                        imgSave.Save(fileName);
                    }
                }
                imgSave.Dispose();
            }
            else
            {
                MessageBox.Show("Зафіксуйте фотографію!");
            }
        }*/

        private void BtnPhotoImg_Click(object sender, EventArgs e)
        {
            imgForSave.Image = (Bitmap)imgWebCam.Image.Clone();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning) cam.Stop();
            this.Close();
        }
    }
}
