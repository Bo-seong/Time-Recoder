namespace MainClientUI
{
    partial class concentrationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConcentrationPageExit = new System.Windows.Forms.Button();
            this.btnConcentrationPageStart = new System.Windows.Forms.Button();
            this.btnCamStop = new System.Windows.Forms.Button();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConcentrationPageExit
            // 
            this.btnConcentrationPageExit.Location = new System.Drawing.Point(713, 12);
            this.btnConcentrationPageExit.Name = "btnConcentrationPageExit";
            this.btnConcentrationPageExit.Size = new System.Drawing.Size(75, 23);
            this.btnConcentrationPageExit.TabIndex = 0;
            this.btnConcentrationPageExit.Text = "종료";
            this.btnConcentrationPageExit.UseVisualStyleBackColor = true;
            this.btnConcentrationPageExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConcentrationPageStart
            // 
            this.btnConcentrationPageStart.Font = new System.Drawing.Font("굴림", 30F);
            this.btnConcentrationPageStart.Location = new System.Drawing.Point(496, 399);
            this.btnConcentrationPageStart.Name = "btnConcentrationPageStart";
            this.btnConcentrationPageStart.Size = new System.Drawing.Size(168, 78);
            this.btnConcentrationPageStart.TabIndex = 2;
            this.btnConcentrationPageStart.Text = "시작";
            this.btnConcentrationPageStart.UseVisualStyleBackColor = true;
            this.btnConcentrationPageStart.Click += new System.EventHandler(this.btnConcentrationPageStart_Click);
            // 
            // btnCamStop
            // 
            this.btnCamStop.Font = new System.Drawing.Font("굴림", 30F);
            this.btnCamStop.Location = new System.Drawing.Point(496, 505);
            this.btnCamStop.Name = "btnCamStop";
            this.btnCamStop.Size = new System.Drawing.Size(168, 85);
            this.btnCamStop.TabIndex = 4;
            this.btnCamStop.Text = "정지";
            this.btnCamStop.UseVisualStyleBackColor = true;
            this.btnCamStop.Click += new System.EventHandler(this.btnCamStop_Click);
            // 
            // picCam
            // 
            this.picCam.Location = new System.Drawing.Point(33, 12);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(656, 368);
            this.picCam.TabIndex = 5;
            this.picCam.TabStop = false;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("굴림", 40F);
            this.domainUpDown1.Location = new System.Drawing.Point(107, 408);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(172, 69);
            this.domainUpDown1.TabIndex = 6;
            this.domainUpDown1.Text = "00:30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.Location = new System.Drawing.Point(98, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:29:58";
            // 
            // concentrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.btnCamStop);
            this.Controls.Add(this.btnConcentrationPageStart);
            this.Controls.Add(this.btnConcentrationPageExit);
            this.Name = "concentrationPage";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.concentrationPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcentrationPageExit;
        private System.Windows.Forms.Button btnConcentrationPageStart;
        private System.Windows.Forms.Button btnCamStop;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
    }
}