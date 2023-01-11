namespace buttontest
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
            this.btnConcentrationPageStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btnConcentrationPageStop
            // 
            this.btnConcentrationPageStop.Font = new System.Drawing.Font("굴림", 30F);
            this.btnConcentrationPageStop.Location = new System.Drawing.Point(496, 505);
            this.btnConcentrationPageStop.Name = "btnConcentrationPageStop";
            this.btnConcentrationPageStop.Size = new System.Drawing.Size(168, 85);
            this.btnConcentrationPageStop.TabIndex = 4;
            this.btnConcentrationPageStop.Text = "정지";
            this.btnConcentrationPageStop.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 368);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConcentrationPageStop);
            this.Controls.Add(this.btnConcentrationPageStart);
            this.Controls.Add(this.btnConcentrationPageExit);
            this.Name = "concentrationPage";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcentrationPageExit;
        private System.Windows.Forms.Button btnConcentrationPageStart;
        private System.Windows.Forms.Button btnConcentrationPageStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
    }
}