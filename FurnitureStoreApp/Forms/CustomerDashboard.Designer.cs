namespace FurnitureStoreApp.Forms
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            Category_CB = new ComboBox();
            filtercategory_btn = new Button();
            searchtxt = new TextBox();
            Searchname_btn = new Button();
            display_btn = new Button();
            showCart_btn = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(Category_CB);
            flowLayoutPanel1.Controls.Add(filtercategory_btn);
            flowLayoutPanel1.Controls.Add(searchtxt);
            flowLayoutPanel1.Controls.Add(Searchname_btn);
            flowLayoutPanel1.Controls.Add(display_btn);
            flowLayoutPanel1.Controls.Add(showCart_btn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1543, 744);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Category_CB
            // 
            Category_CB.BackColor = Color.FromArgb(239, 236, 229);
            Category_CB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_CB.ForeColor = Color.FromArgb(64, 51, 35);
            Category_CB.FormattingEnabled = true;
            Category_CB.Location = new Point(103, 3);
            Category_CB.Name = "Category_CB";
            Category_CB.Size = new Size(177, 33);
            Category_CB.TabIndex = 25;
            Category_CB.SelectedIndexChanged += Category_CB_SelectedIndexChanged;
            // 
            // filtercategory_btn
            // 
            filtercategory_btn.FlatAppearance.BorderSize = 0;
            filtercategory_btn.FlatStyle = FlatStyle.Flat;
            filtercategory_btn.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filtercategory_btn.ForeColor = Color.DarkOliveGreen;
            filtercategory_btn.Location = new Point(286, 3);
            filtercategory_btn.Name = "filtercategory_btn";
            filtercategory_btn.Size = new Size(227, 45);
            filtercategory_btn.TabIndex = 24;
            filtercategory_btn.Text = "Filter By Category";
            filtercategory_btn.UseVisualStyleBackColor = false;
            filtercategory_btn.Click += filtercategory_btn_Click;
            // 
            // searchtxt
            // 
            searchtxt.BackColor = Color.FromArgb(239, 236, 229);
            searchtxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchtxt.ForeColor = Color.FromArgb(64, 51, 35);
            searchtxt.Location = new Point(519, 3);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(177, 31);
            searchtxt.TabIndex = 23;
            // 
            // Searchname_btn
            // 
            Searchname_btn.FlatAppearance.BorderSize = 0;
            Searchname_btn.FlatStyle = FlatStyle.Flat;
            Searchname_btn.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchname_btn.ForeColor = Color.DarkOliveGreen;
            Searchname_btn.Location = new Point(702, 3);
            Searchname_btn.Name = "Searchname_btn";
            Searchname_btn.Size = new Size(184, 45);
            Searchname_btn.TabIndex = 22;
            Searchname_btn.Text = "Search Product";
            Searchname_btn.UseVisualStyleBackColor = false;
            Searchname_btn.Click += searchProduct_Click;
            // 
            // display_btn
            // 
            display_btn.FlatAppearance.BorderSize = 0;
            display_btn.FlatStyle = FlatStyle.Flat;
            display_btn.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display_btn.ForeColor = Color.DarkOliveGreen;
            display_btn.Location = new Point(892, 3);
            display_btn.Name = "display_btn";
            display_btn.Size = new Size(167, 45);
            display_btn.TabIndex = 26;
            display_btn.Text = "Display All";
            display_btn.UseVisualStyleBackColor = false;
            display_btn.Click += display_btn_Click;
            // 
            // showCart_btn
            // 
            showCart_btn.FlatAppearance.BorderSize = 0;
            showCart_btn.FlatStyle = FlatStyle.Flat;
            showCart_btn.Font = new Font("Lucida Sans Unicode", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showCart_btn.ForeColor = Color.DarkOliveGreen;
            showCart_btn.Location = new Point(1065, 3);
            showCart_btn.Name = "showCart_btn";
            showCart_btn.Size = new Size(193, 45);
            showCart_btn.TabIndex = 27;
            showCart_btn.Text = "Show Cart";
            showCart_btn.UseVisualStyleBackColor = false;
            showCart_btn.Click += showCart_btn_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(1543, 744);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerDashboard";
            Text = "Oasis";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button filtercategory_btn;
        private ComboBox Category_CB;
        private Button Searchname_btn;
        private TextBox searchtxt;
        private Button display_btn;
        private Button showCart_btn;
        private PictureBox pictureBox1;
    }
}