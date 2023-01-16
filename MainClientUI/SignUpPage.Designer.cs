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
            this.txt_regID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_regID = new System.Windows.Forms.Label();
            this.lbl_regPW = new System.Windows.Forms.Label();
            this.lbl_checkRegPW = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_userPhone = new System.Windows.Forms.Label();
            this.lbl_birthYear = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_WelcomeMsg = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_regID
            // 
            this.txt_regID.Location = new System.Drawing.Point(271, 168);
            this.txt_regID.Name = "txt_regID";
            this.txt_regID.Size = new System.Drawing.Size(200, 21);
            this.txt_regID.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '●';
            this.textBox3.Size = new System.Drawing.Size(200, 21);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(271, 326);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 21);
            this.textBox4.TabIndex = 3;
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
            this.lbl_regID.Click += new System.EventHandler(this.label1_Click);
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
            this.lbl_userName.Click += new System.EventHandler(this.lbl_userName_Click);
            // 
            // lbl_userPhone
            // 
            this.lbl_userPhone.AutoSize = true;
            this.lbl_userPhone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userPhone.Location = new System.Drawing.Point(135, 378);
            this.lbl_userPhone.Name = "lbl_userPhone";
            this.lbl_userPhone.Size = new System.Drawing.Size(93, 24);
            this.lbl_userPhone.TabIndex = 8;
            this.lbl_userPhone.Text = "전화 번호 :";
            // 
            // lbl_birthYear
            // 
            this.lbl_birthYear.AutoSize = true;
            this.lbl_birthYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthYear.Location = new System.Drawing.Point(135, 432);
            this.lbl_birthYear.Name = "lbl_birthYear";
            this.lbl_birthYear.Size = new System.Drawing.Size(93, 24);
            this.lbl_birthYear.TabIndex = 9;
            this.lbl_birthYear.Text = "출생 년도 :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(271, 381);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 21);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(271, 435);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 21);
            this.textBox6.TabIndex = 11;
            // 
            // btn_register
            // 
            this.btn_register.AutoSize = true;
            this.btn_register.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(232, 554);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 42);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "가입";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(338, 554);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 42);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "뒤로";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_WelcomeMsg
            // 
            this.lbl_WelcomeMsg.AutoSize = true;
            this.lbl_WelcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_WelcomeMsg.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeMsg.Location = new System.Drawing.Point(185, 37);
            this.lbl_WelcomeMsg.Name = "lbl_WelcomeMsg";
            this.lbl_WelcomeMsg.Size = new System.Drawing.Size(241, 58);
            this.lbl_WelcomeMsg.TabIndex = 15;
            this.lbl_WelcomeMsg.Text = "환영합니다!";
            this.lbl_WelcomeMsg.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(139, 508);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "회원 약관에 동의합니다.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 655);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_WelcomeMsg);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lbl_birthYear);
            this.Controls.Add(this.lbl_userPhone);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.lbl_checkRegPW);
            this.Controls.Add(this.lbl_regPW);
            this.Controls.Add(this.lbl_regID);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_regID);
            this.Name = "SignUpPage";
            this.Text = "회원 가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_regID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_regID;
        private System.Windows.Forms.Label lbl_regPW;
        private System.Windows.Forms.Label lbl_checkRegPW;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_userPhone;
        private System.Windows.Forms.Label lbl_birthYear;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_WelcomeMsg;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}