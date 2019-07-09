﻿using System;
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
    }
}
