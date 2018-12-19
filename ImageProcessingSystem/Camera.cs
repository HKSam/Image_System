using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.IO;

namespace ImageProcessingSystem
{
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevices;
        //连接摄像头
        private void CameraConn()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[tscbxCameras.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            videPlayer.VideoSource = videoSource;
            videPlayer.Start();
        }

        private void link_Click(object sender, EventArgs e)
        {
            try
            {
                CameraConn();
            }
            catch { }
        }
        private void Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close_Click(null, null);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            videPlayer.SignalToStop();
            videPlayer.WaitForStop();
        }

        private void Img_save_Click(object sender, EventArgs e)
        {
            System.Drawing.Image img = new Bitmap(videPlayer.Width, videPlayer.Height);
            videPlayer.DrawToBitmap((Bitmap)img, new Rectangle(0, 0, videPlayer.Width, videPlayer.Height));
            img.Save(@"C:\a.bmp", ImageFormat.Bmp);
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    tscbxCameras.Items.Add(device.Name);
                }

                tscbxCameras.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                tscbxCameras.Items.Add("No local capture devices");
                videoDevices = null;
            }
        }
    }
}
