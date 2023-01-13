using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace testapp
{
    public partial class Form1 : Form
    {
        private VideoCapture video;
        private Thread thread;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void videoThread()
        {
            Mat mat = new Mat();
            while (true)
            {
                video.Read(mat);
                pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            video = new VideoCapture(0);
            thread = new Thread(new ThreadStart(videoThread));
            thread.Start();
            }
    }
    }

