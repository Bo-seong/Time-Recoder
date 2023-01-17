using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace MainClientUI
{
    public partial class concentrationPage : Form
    {

        public concentrationPage()
        {
            InitializeComponent();
        }

        private VideoCapture video;
        private Thread thread;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConcentrationPageStart_Click(object sender, EventArgs e)
        {
            video = new VideoCapture(0);
            thread = new Thread(new ThreadStart(videoThread));
            //thread.IsBackground = true;
            thread.Start();
        }

        private void videoThread()
        {
            Mat mat = new Mat();
            while (true)
            {
                try
                {
                    video.Read(mat);
                    Cv2.Flip(mat, mat, FlipMode.Y);
                    picCam.Image =
                        OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
                }
                catch(Exception e)
                {
                    video.Release();
                    thread.Abort();
                    continue;
                }
            }
        }

        private void btnCamStop_Click(object sender, EventArgs e)
        {
            video.Release();
            thread.Abort();
            picCam.Image = null;
        }

        private void concentrationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            video.Release();
            thread.Abort();
            Application.Exit();
        }
    }
}
