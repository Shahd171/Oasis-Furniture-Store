namespace FurnitureStoreApp.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            email_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            email_txt = new TextBox();
            password_txt = new TextBox();
            login_btn = new Button();
            label4 = new Label();
            signup_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Lucida Sans Unicode", 9F);
            email_lbl.ForeColor = Color.DarkOliveGreen;
            email_lbl.Location = new Point(73, 251);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(57, 22);
            email_lbl.TabIndex = 0;
            email_lbl.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 9F);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(73, 339);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(46, 47);
            label2.Name = "label2";
            label2.Size = new Size(235, 87);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(73, 157);
            label3.Name = "label3";
            label3.Size = new Size(240, 22);
            label3.TabIndex = 3;
            label3.Text = "Please Sign in to continue.";
            // 
            // email_txt
            // 
            email_txt.BackColor = Color.FromArgb(239, 236, 229);
            email_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_txt.ForeColor = Color.FromArgb(64, 51, 35);
            email_txt.Location = new Point(205, 246);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(353, 31);
            email_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            password_txt.BackColor = Color.FromArgb(239, 236, 229);
            password_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password_txt.ForeColor = Color.FromArgb(64, 51, 35);
            password_txt.Location = new Point(205, 330);
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(353, 31);
            password_txt.TabIndex = 5;
            // 
            // login_btn
            // 
            login_btn.FlatAppearance.BorderSize = 2;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.DarkOliveGreen;
            login_btn.Location = new Point(313, 417);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(130, 54);
            login_btn.TabIndex = 6;
            login_btn.Text = "LogIn";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(244, 528);
            label4.Name = "label4";
            label4.Size = new Size(247, 22);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?  ";
            // 
            // signup_btn
            // 
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.DarkOliveGreen;
            signup_btn.Location = new Point(477, 513);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(135, 49);
            signup_btn.TabIndex = 8;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(779, 660);
            Controls.Add(pictureBox1);
            Controls.Add(signup_btn);
            Controls.Add(label4);
            Controls.Add(login_btn);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email_lbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogInForm";
            Text = "Oasis";
            FormClosing += LogInForm_FormClosing;
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label email_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox email_txt;
        private TextBox password_txt;
        private Button login_btn;
        private Label label4;
        private Button signup_btn;
        private PictureBox pictureBox1;
    }
}