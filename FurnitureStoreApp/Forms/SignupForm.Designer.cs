namespace FurnitureStoreApp.Forms
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            label2 = new Label();
            label3 = new Label();
            password_txt = new TextBox();
            email_txt = new TextBox();
            label1 = new Label();
            email_lbl = new Label();
            Name_txt = new TextBox();
            Name_lbl = new Label();
            confirmpass_txt = new TextBox();
            Confirm_pass_lbl = new Label();
            signup_btn = new Button();
            NameErrorLabel = new Label();
            emailErrorLabel = new Label();
            passwordErrorLabel = new Label();
            confirmPwErrorLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(52, 22);
            label2.Name = "label2";
            label2.Size = new Size(312, 87);
            label2.TabIndex = 3;
            label2.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(104, 143);
            label3.Name = "label3";
            label3.Size = new Size(246, 22);
            label3.TabIndex = 4;
            label3.Text = "Please Sign up to continue.";
            // 
            // password_txt
            // 
            password_txt.BackColor = Color.FromArgb(239, 236, 229);
            password_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.FromArgb(64, 51, 35);
            password_txt.Location = new Point(295, 418);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(353, 31);
            password_txt.TabIndex = 9;
            // 
            // email_txt
            // 
            email_txt.BackColor = Color.FromArgb(239, 236, 229);
            email_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_txt.ForeColor = Color.FromArgb(64, 51, 35);
            email_txt.Location = new Point(295, 312);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(353, 31);
            email_txt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 9F);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(109, 418);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Lucida Sans Unicode", 9F);
            email_lbl.ForeColor = Color.DarkOliveGreen;
            email_lbl.Location = new Point(109, 317);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(57, 22);
            email_lbl.TabIndex = 6;
            email_lbl.Text = "Email";
            // 
            // Name_txt
            // 
            Name_txt.BackColor = Color.FromArgb(239, 236, 229);
            Name_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Name_txt.Location = new Point(295, 217);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(353, 31);
            Name_txt.TabIndex = 11;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Lucida Sans Unicode", 9F);
            Name_lbl.ForeColor = Color.DarkOliveGreen;
            Name_lbl.Location = new Point(109, 222);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(60, 22);
            Name_lbl.TabIndex = 10;
            Name_lbl.Text = "Name";
            // 
            // confirmpass_txt
            // 
            confirmpass_txt.BackColor = Color.FromArgb(239, 236, 229);
            confirmpass_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmpass_txt.ForeColor = Color.FromArgb(64, 51, 35);
            confirmpass_txt.Location = new Point(295, 511);
            confirmpass_txt.Name = "confirmpass_txt";
            confirmpass_txt.PasswordChar = '*';
            confirmpass_txt.Size = new Size(353, 31);
            confirmpass_txt.TabIndex = 13;
            // 
            // Confirm_pass_lbl
            // 
            Confirm_pass_lbl.AutoSize = true;
            Confirm_pass_lbl.Font = new Font("Lucida Sans Unicode", 9F);
            Confirm_pass_lbl.ForeColor = Color.DarkOliveGreen;
            Confirm_pass_lbl.Location = new Point(109, 516);
            Confirm_pass_lbl.Name = "Confirm_pass_lbl";
            Confirm_pass_lbl.Size = new Size(167, 22);
            Confirm_pass_lbl.TabIndex = 12;
            Confirm_pass_lbl.Text = "Confirm Password";
            // 
            // signup_btn
            // 
            signup_btn.FlatAppearance.BorderSize = 2;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.DarkOliveGreen;
            signup_btn.Location = new Point(762, 586);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(231, 54);
            signup_btn.TabIndex = 14;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // NameErrorLabel
            // 
            NameErrorLabel.AutoSize = true;
            NameErrorLabel.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameErrorLabel.ForeColor = Color.Maroon;
            NameErrorLabel.Location = new Point(700, 222);
            NameErrorLabel.Name = "NameErrorLabel";
            NameErrorLabel.Size = new Size(64, 22);
            NameErrorLabel.TabIndex = 15;
            NameErrorLabel.Text = "Name";
            NameErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailErrorLabel.ForeColor = Color.Maroon;
            emailErrorLabel.Location = new Point(700, 317);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(64, 22);
            emailErrorLabel.TabIndex = 16;
            emailErrorLabel.Text = "Name";
            emailErrorLabel.Visible = false;
            emailErrorLabel.Click += emailErrorLabel_Click;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordErrorLabel.ForeColor = Color.Maroon;
            passwordErrorLabel.Location = new Point(700, 418);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(64, 22);
            passwordErrorLabel.TabIndex = 17;
            passwordErrorLabel.Text = "Name";
            passwordErrorLabel.Visible = false;
            // 
            // confirmPwErrorLabel
            // 
            confirmPwErrorLabel.AutoSize = true;
            confirmPwErrorLabel.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPwErrorLabel.ForeColor = Color.Maroon;
            confirmPwErrorLabel.Location = new Point(700, 516);
            confirmPwErrorLabel.Name = "confirmPwErrorLabel";
            confirmPwErrorLabel.Size = new Size(64, 22);
            confirmPwErrorLabel.TabIndex = 18;
            confirmPwErrorLabel.Text = "Name";
            confirmPwErrorLabel.Visible = false;
            confirmPwErrorLabel.Click += confirmPwErrorLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(1331, 699);
            Controls.Add(pictureBox1);
            Controls.Add(confirmPwErrorLabel);
            Controls.Add(passwordErrorLabel);
            Controls.Add(emailErrorLabel);
            Controls.Add(NameErrorLabel);
            Controls.Add(signup_btn);
            Controls.Add(confirmpass_txt);
            Controls.Add(Confirm_pass_lbl);
            Controls.Add(Name_txt);
            Controls.Add(Name_lbl);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(label1);
            Controls.Add(email_lbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignupForm";
            Text = "Oasis";
            FormClosing += SignupForm_FormClosing;
            Load += SignupForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox password_txt;
        private TextBox email_txt;
        private Label label1;
        private Label email_lbl;
        private TextBox Name_txt;
        private Label Name_lbl;
        private TextBox confirmpass_txt;
        private Label Confirm_pass_lbl;
        private Button signup_btn;
        private Label NameErrorLabel;
        private Label emailErrorLabel;
        private Label passwordErrorLabel;
        private Label confirmPwErrorLabel;
        private PictureBox pictureBox1;
    }
}