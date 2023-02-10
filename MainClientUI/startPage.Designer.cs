namespace MainClientUI
{
    partial class startForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtLoginPW = new System.Windows.Forms.TextBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_input_ID = new System.Windows.Forms.Label();
            this.lbl_input_PW = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.concernTimer = new System.Windows.Forms.Timer(this.components);
            this.startPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(126, 264);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 53);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginID
            // 
            this.txtLoginID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginID.Location = new System.Drawing.Point(267, 130);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(181, 21);
            this.txtLoginID.TabIndex = 1;
            // 
            // txtLoginPW
            // 
            this.txtLoginPW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPW.Location = new System.Drawing.Point(267, 184);
            this.txtLoginPW.Name = "txtLoginPW";
            this.txtLoginPW.Size = new System.Drawing.Size(181, 21);
            this.txtLoginPW.TabIndex = 3;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(185, 14);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(237, 56);
            this.titelLabel.TabIndex = 4;
            this.titelLabel.Text = "집중 타이머";
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(311, 264);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(137, 53);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "회원가입";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(511, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl_input_ID
            // 
            this.lbl_input_ID.AutoSize = true;
            this.lbl_input_ID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_ID.Location = new System.Drawing.Point(121, 125);
            this.lbl_input_ID.Name = "lbl_input_ID";
            this.lbl_input_ID.Size = new System.Drawing.Size(84, 29);
            this.lbl_input_ID.TabIndex = 7;
            this.lbl_input_ID.Text = "아이디 :";
            // 
            // lbl_input_PW
            // 
            this.lbl_input_PW.AutoSize = true;
            this.lbl_input_PW.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_PW.Location = new System.Drawing.Point(121, 179);
            this.lbl_input_PW.Name = "lbl_input_PW";
            this.lbl_input_PW.Size = new System.Drawing.Size(103, 29);
            this.lbl_input_PW.TabIndex = 8;
            this.lbl_input_PW.Text = "비밀번호 :";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.lbl_input_PW);
            this.startPanel.Controls.Add(this.titelLabel);
            this.startPanel.Controls.Add(this.lbl_input_ID);
            this.startPanel.Controls.Add(this.btnExit);
            this.startPanel.Controls.Add(this.btnSignup);
            this.startPanel.Controls.Add(this.txtLoginPW);
            this.startPanel.Controls.Add(this.btnLogin);
            this.startPanel.Controls.Add(this.txtLoginID);
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(600, 400);
            this.startPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startPanel);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblSecond);
            this.panel1.Controls.Add(this.picCam);
            this.panel1.Controls.Add(this.lblMinute);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTimerStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTimerStop);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 400);
            this.panel1.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(514, 158);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(222, 275);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(44, 32);
            this.lblSecond.TabIndex = 11;
            this.lblSecond.Text = "00";
            // 
            // picCam
            // 
            this.picCam.Location = new System.Drawing.Point(20, 15);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(320, 240);
            this.picCam.TabIndex = 5;
            this.picCam.TabStop = false;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(151, 275);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(44, 32);
            this.lblMinute.TabIndex = 10;
            this.lblMinute.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMinute);
            this.groupBox1.Controls.Add(this.numHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(359, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시간 설정";
            // 
            // numMinute
            // 
            this.numMinute.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinute.Location = new System.Drawing.Point(132, 31);
            this.numMinute.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(50, 35);
            this.numMinute.TabIndex = 11;
            // 
            // numHour
            // 
            this.numHour.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHour.Location = new System.Drawing.Point(18, 31);
            this.numHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(49, 35);
            this.numHour.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "시";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(82, 275);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(44, 32);
            this.lblHour.TabIndex = 9;
            this.lblHour.Text = "00";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.Location = new System.Drawing.Point(509, 15);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 30);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "종료";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStart.Location = new System.Drawing.Point(357, 158);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(75, 30);
            this.btnTimerStart.TabIndex = 2;
            this.btnTimerStart.Text = "시작";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStop.Location = new System.Drawing.Point(436, 158);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(75, 30);
            this.btnTimerStop.TabIndex = 4;
            this.btnTimerStop.Text = "정지";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // concernTimer
            // 
            this.concernTimer.Interval = 1000;
            this.concernTimer.Tick += new System.EventHandler(this.concernTimer_Tick);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 448);
            this.Controls.Add(this.panel1);
            this.Name = "startForm";
            this.Text = "집중 타이머";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox txtLoginPW;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl_input_ID;
        private System.Windows.Forms.Label lbl_input_PW;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.Timer concernTimer;
        private System.Windows.Forms.Button btnReset;
    }
}

