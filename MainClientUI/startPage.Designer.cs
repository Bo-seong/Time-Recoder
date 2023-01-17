namespace MainClientUI
{
    partial class startPage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtLoginPW = new System.Windows.Forms.TextBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_input_ID = new System.Windows.Forms.Label();
            this.lbl_input_PW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(184, 306);
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
            this.txtLoginID.Location = new System.Drawing.Point(325, 172);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(181, 21);
            this.txtLoginID.TabIndex = 1;
            // 
            // txtLoginPW
            // 
            this.txtLoginPW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPW.Location = new System.Drawing.Point(325, 226);
            this.txtLoginPW.Name = "txtLoginPW";
            this.txtLoginPW.Size = new System.Drawing.Size(181, 21);
            this.txtLoginPW.TabIndex = 3;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(227, 52);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(237, 56);
            this.titelLabel.TabIndex = 4;
            this.titelLabel.Text = "집중 타이머";
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(369, 306);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(137, 53);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "회원가입";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(589, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_input_ID
            // 
            this.lbl_input_ID.AutoSize = true;
            this.lbl_input_ID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_ID.Location = new System.Drawing.Point(179, 167);
            this.lbl_input_ID.Name = "lbl_input_ID";
            this.lbl_input_ID.Size = new System.Drawing.Size(84, 29);
            this.lbl_input_ID.TabIndex = 7;
            this.lbl_input_ID.Text = "아이디 :";
            this.lbl_input_ID.Click += new System.EventHandler(this.lbl_input_ID_Click);
            // 
            // lbl_input_PW
            // 
            this.lbl_input_PW.AutoSize = true;
            this.lbl_input_PW.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input_PW.Location = new System.Drawing.Point(179, 221);
            this.lbl_input_PW.Name = "lbl_input_PW";
            this.lbl_input_PW.Size = new System.Drawing.Size(103, 29);
            this.lbl_input_PW.TabIndex = 8;
            this.lbl_input_PW.Text = "비밀번호 :";
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 439);
            this.Controls.Add(this.lbl_input_PW);
            this.Controls.Add(this.lbl_input_ID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.txtLoginPW);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.btnLogin);
            this.Name = "startPage";
            this.Text = "집중 타이머";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

