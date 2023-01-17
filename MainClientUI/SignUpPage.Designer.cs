namespace MainClientUI
{
    partial class SignUpPage
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
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.txtRegPW = new System.Windows.Forms.TextBox();
            this.txtCheckRegPW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl_regID = new System.Windows.Forms.Label();
            this.lbl_regPW = new System.Windows.Forms.Label();
            this.lbl_checkRegPW = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl_regTitle = new System.Windows.Forms.Label();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(271, 166);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(200, 21);
            this.txtRegID.TabIndex = 0;
            // 
            // txtRegPW
            // 
            this.txtRegPW.Location = new System.Drawing.Point(271, 220);
            this.txtRegPW.Name = "txtRegPW";
            this.txtRegPW.PasswordChar = '●';
            this.txtRegPW.Size = new System.Drawing.Size(200, 21);
            this.txtRegPW.TabIndex = 1;
            // 
            // txtCheckRegPW
            // 
            this.txtCheckRegPW.Location = new System.Drawing.Point(271, 274);
            this.txtCheckRegPW.Name = "txtCheckRegPW";
            this.txtCheckRegPW.PasswordChar = '●';
            this.txtCheckRegPW.Size = new System.Drawing.Size(200, 21);
            this.txtCheckRegPW.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(271, 326);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 21);
            this.txtUserName.TabIndex = 3;
            // 
            // lbl_regID
            // 
            this.lbl_regID.AutoSize = true;
            this.lbl_regID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regID.Location = new System.Drawing.Point(135, 165);
            this.lbl_regID.Name = "lbl_regID";
            this.lbl_regID.Size = new System.Drawing.Size(71, 24);
            this.lbl_regID.TabIndex = 4;
            this.lbl_regID.Text = "아이디 :";
            // 
            // lbl_regPW
            // 
            this.lbl_regPW.AutoSize = true;
            this.lbl_regPW.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regPW.Location = new System.Drawing.Point(135, 217);
            this.lbl_regPW.Name = "lbl_regPW";
            this.lbl_regPW.Size = new System.Drawing.Size(87, 24);
            this.lbl_regPW.TabIndex = 5;
            this.lbl_regPW.Text = "비밀번호 :";
            // 
            // lbl_checkRegPW
            // 
            this.lbl_checkRegPW.AutoSize = true;
            this.lbl_checkRegPW.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkRegPW.Location = new System.Drawing.Point(135, 271);
            this.lbl_checkRegPW.Name = "lbl_checkRegPW";
            this.lbl_checkRegPW.Size = new System.Drawing.Size(125, 24);
            this.lbl_checkRegPW.TabIndex = 6;
            this.lbl_checkRegPW.Text = "비밀번호 확인 :";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(135, 323);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(67, 24);
            this.lbl_userName.TabIndex = 7;
            this.lbl_userName.Text = "이  름 :";
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPhone.Location = new System.Drawing.Point(135, 378);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(93, 24);
            this.lblUserPhone.TabIndex = 8;
            this.lblUserPhone.Text = "전화 번호 :";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(135, 432);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(93, 24);
            this.lblBirthYear.TabIndex = 9;
            this.lblBirthYear.Text = "출생 년도 :";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(271, 381);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(200, 21);
            this.txtUserPhone.TabIndex = 10;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(271, 435);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(200, 21);
            this.txtBirthYear.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(232, 554);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 42);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "가입";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(338, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "뒤로";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_regTitle
            // 
            this.lbl_regTitle.AutoSize = true;
            this.lbl_regTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_regTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regTitle.Location = new System.Drawing.Point(185, 37);
            this.lbl_regTitle.Name = "lbl_regTitle";
            this.lbl_regTitle.Size = new System.Drawing.Size(241, 58);
            this.lbl_regTitle.TabIndex = 15;
            this.lbl_regTitle.Text = "환영합니다!";
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgree.Location = new System.Drawing.Point(139, 496);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(148, 20);
            this.chkAgree.TabIndex = 16;
            this.chkAgree.Text = "회원 약관에 동의합니다.";
            this.chkAgree.UseVisualStyleBackColor = true;
            this.chkAgree.CheckedChanged += new System.EventHandler(this.chkAgree_CheckedChanged);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 655);
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.lbl_regTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblUserPhone);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_checkRegPW);
            this.Controls.Add(this.lbl_regPW);
            this.Controls.Add(this.lbl_regID);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtCheckRegPW);
            this.Controls.Add(this.txtRegPW);
            this.Controls.Add(this.txtRegID);
            this.Name = "SignUpPage";
            this.Text = "회원 가입";
            this.Load += new System.EventHandler(this.SignUpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.TextBox txtRegPW;
        private System.Windows.Forms.TextBox txtCheckRegPW;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl_regID;
        private System.Windows.Forms.Label lbl_regPW;
        private System.Windows.Forms.Label lbl_checkRegPW;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl_regTitle;
        private System.Windows.Forms.CheckBox chkAgree;
    }
}