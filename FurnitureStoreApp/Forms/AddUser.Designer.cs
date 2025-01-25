namespace FurnitureStoreApp.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            addUser_btn = new Button();
            label1 = new Label();
            Password_lbl = new Label();
            email_txt = new TextBox();
            Email_lbl = new Label();
            Name_lbl = new Label();
            Name_txt = new TextBox();
            Role_CB = new ComboBox();
            Password_txt = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addUser_btn
            // 
            addUser_btn.FlatAppearance.BorderSize = 2;
            addUser_btn.FlatStyle = FlatStyle.Flat;
            addUser_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_btn.ForeColor = Color.DarkOliveGreen;
            addUser_btn.Location = new Point(583, 501);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(196, 71);
            addUser_btn.TabIndex = 25;
            addUser_btn.Text = "Add";
            addUser_btn.UseVisualStyleBackColor = false;
            addUser_btn.Click += addUser_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11F);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(131, 444);
            label1.Name = "label1";
            label1.Size = new Size(58, 27);
            label1.TabIndex = 20;
            label1.Text = "Role";
            // 
            // Password_lbl
            // 
            Password_lbl.AutoSize = true;
            Password_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Password_lbl.ForeColor = Color.DarkOliveGreen;
            Password_lbl.Location = new Point(131, 334);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(112, 27);
            Password_lbl.TabIndex = 18;
            Password_lbl.Text = "Password";
            // 
            // email_txt
            // 
            email_txt.BackColor = Color.FromArgb(239, 236, 229);
            email_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_txt.ForeColor = Color.FromArgb(64, 51, 35);
            email_txt.Location = new Point(354, 238);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(191, 31);
            email_txt.TabIndex = 17;
            // 
            // Email_lbl
            // 
            Email_lbl.AutoSize = true;
            Email_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Email_lbl.ForeColor = Color.DarkOliveGreen;
            Email_lbl.Location = new Point(131, 238);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(69, 27);
            Email_lbl.TabIndex = 16;
            Email_lbl.Text = "Email";
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Name_lbl.ForeColor = Color.DarkOliveGreen;
            Name_lbl.Location = new Point(131, 138);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(127, 27);
            Name_lbl.TabIndex = 15;
            Name_lbl.Text = "User Name";
            // 
            // Name_txt
            // 
            Name_txt.BackColor = Color.FromArgb(239, 236, 229);
            Name_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Name_txt.Location = new Point(354, 138);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(191, 31);
            Name_txt.TabIndex = 14;
            // 
            // Role_CB
            // 
            Role_CB.BackColor = Color.FromArgb(239, 236, 229);
            Role_CB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role_CB.ForeColor = Color.FromArgb(64, 51, 35);
            Role_CB.FormattingEnabled = true;
            Role_CB.Location = new Point(354, 443);
            Role_CB.Name = "Role_CB";
            Role_CB.Size = new Size(191, 33);
            Role_CB.TabIndex = 26;
            // 
            // Password_txt
            // 
            Password_txt.BackColor = Color.FromArgb(239, 236, 229);
            Password_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Password_txt.Location = new Point(354, 333);
            Password_txt.Name = "Password_txt";
            Password_txt.PasswordChar = '*';
            Password_txt.Size = new Size(191, 31);
            Password_txt.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(83, 9);
            label3.Name = "label3";
            label3.Size = new Size(364, 87);
            label3.TabIndex = 48;
            label3.Text = "Add User";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(816, 653);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Password_txt);
            Controls.Add(Role_CB);
            Controls.Add(addUser_btn);
            Controls.Add(label1);
            Controls.Add(Password_lbl);
            Controls.Add(email_txt);
            Controls.Add(Email_lbl);
            Controls.Add(Name_lbl);
            Controls.Add(Name_txt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUser";
            Text = "Oasis";
            FormClosing += AddUser_FormClosing;
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addUser_btn;
        private Label label1;
        private Label Password_lbl;
        private TextBox email_txt;
        private Label Email_lbl;
        private Label Name_lbl;
        private TextBox Name_txt;
        private ComboBox Role_CB;
        private TextBox Password_txt;
        private PictureBox pictureBox1;
        private Label label3;
    }
}