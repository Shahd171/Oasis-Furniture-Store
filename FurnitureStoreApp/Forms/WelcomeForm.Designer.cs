
namespace FurnitureStoreApp
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            pictureBox1 = new PictureBox();
            welcome = new Label();
            message = new Label();
            shop = new Button();
            login_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(614, 711);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.DarkOliveGreen;
            welcome.Location = new Point(690, 48);
            welcome.Name = "welcome";
            welcome.Size = new Size(493, 174);
            welcome.TabIndex = 3;
            welcome.Text = "Welcome\n \t \t \t \t To Oasis ";
            welcome.Click += label1_Click;
            // 
            // message
            // 
            message.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message.ForeColor = Color.DarkOliveGreen;
            message.Location = new Point(690, 287);
            message.Name = "message";
            message.Size = new Size(560, 270);
            message.TabIndex = 5;
            message.Text = resources.GetString("message.Text");
            message.Click += label2_Click;
            // 
            // shop
            // 
            shop.FlatAppearance.BorderSize = 2;
            shop.FlatStyle = FlatStyle.Flat;
            shop.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shop.ForeColor = Color.DarkOliveGreen;
            shop.Location = new Point(1113, 583);
            shop.Name = "shop";
            shop.Size = new Size(151, 54);
            shop.TabIndex = 6;
            shop.Text = "Shop Now";
            shop.UseVisualStyleBackColor = false;
            shop.Click += shop_Click;
            // 
            // login_btn
            // 
            login_btn.FlatAppearance.BorderSize = 2;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.DarkOliveGreen;
            login_btn.Location = new Point(690, 583);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(151, 54);
            login_btn.TabIndex = 7;
            login_btn.Text = "LogIn";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(1359, 679);
            Controls.Add(login_btn);
            Controls.Add(shop);
            Controls.Add(message);
            Controls.Add(welcome);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(98, 92, 71);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            Text = "Oasis";
            FormClosing += WelcomeForm_FormClosing;
            Load += WelcomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcome;
        private Label message;
        private Button shop;
        private Button login_btn;
    }
}
