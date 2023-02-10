using OpenCvSharp;
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

namespace MainClientUI
{
    public partial class startForm : Form
    {
        private VideoCapture video;
        private Thread thread;


        public startForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그인 되었습니다.", "로그인",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

            startPanel.Hide();
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage newform3 = new SignUpPage();
            newform3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            if (numHour.Value != 0 || numMinute.Value != 0)
            {
                lblHour.Text = numHour.Value.ToString();
                lblMinute.Text = numMinute.Value.ToString();

                video = new VideoCapture(0);
                thread = new Thread(new ThreadStart(videoThread));
                thread.Start();
                concernTimer.Start();
            }
            else
            {
                MessageBox.Show("시간을 설정해주세요.", "시간 설정", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                catch (Exception e)
                {
                    video.Release();
                    thread.Abort();
                    continue;
                }
            }
        }
        
        private void concernTimer_Tick(object sender, EventArgs e)
        {
            int hour = int.Parse(lblHour.Text);
            int minute = int.Parse(lblMinute.Text);
            int second = int.Parse(lblSecond.Text);

            if (hour == 0 & minute == 0 && second == 0)
            {
                concernTimer.Stop();
                video.Release();
                thread.Abort();
                MessageBox.Show("성공하였습니다!", "집중 성공",
                    MessageBoxButtons.OK);

                picCam.Image = null;
            }

            else if (second == 0 && minute > 0)
            {
                minute -= 1;
                second += 59;
                lblMinute.Text = minute.ToString();
                lblSecond.Text = second.ToString();
            }
            else if (hour > 0 && minute == 0 && second == 0)
            {
                hour -= 1;
                minute += 58;
                second += 59;
                lblHour.Text = hour.ToString();
                lblMinute.Text = minute.ToString();
                lblSecond.Text = second.ToString();
            }   
            else
            {
                second -= 1;
                lblSecond.Text = second.ToString();
            }
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            try
            {
                video.Release();
                thread.Abort();
                picCam.Image = null;
                concernTimer.Stop();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            concernTimer.Stop();
            lblHour.Text = "0";
            lblMinute.Text = "0";
            lblSecond.Text = "0";

            try
            {
                video.Release();
                thread.Abort();
                picCam.Image = null;
                concernTimer.Stop();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            try
            {
                video.Release();
                thread.Abort();
                picCam.Image = null;
                concernTimer.Stop();
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
