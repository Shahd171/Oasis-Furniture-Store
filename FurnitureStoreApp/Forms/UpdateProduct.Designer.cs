namespace FurnitureStoreApp.Forms
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            updateproduct_btn = new Button();
            Categories_lbl = new Label();
            Categories = new CheckedListBox();
            Image_txt = new TextBox();
            Browse_btn = new Button();
            Image_lbl = new Label();
            stock_txt = new TextBox();
            Stock_lbl = new Label();
            price_txt = new TextBox();
            Price_lbl = new Label();
            Name_lbl = new Label();
            Product_CB = new ComboBox();
            PName_lbl = new Label();
            Name_txt = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // updateproduct_btn
            // 
            updateproduct_btn.FlatAppearance.BorderSize = 2;
            updateproduct_btn.FlatStyle = FlatStyle.Flat;
            updateproduct_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateproduct_btn.ForeColor = Color.DarkOliveGreen;
            updateproduct_btn.Location = new Point(698, 596);
            updateproduct_btn.Name = "updateproduct_btn";
            updateproduct_btn.Size = new Size(196, 69);
            updateproduct_btn.TabIndex = 25;
            updateproduct_btn.Text = "Update";
            updateproduct_btn.UseVisualStyleBackColor = false;
            updateproduct_btn.Click += updateproduct_btn_Click;
            // 
            // Categories_lbl
            // 
            Categories_lbl.AutoSize = true;
            Categories_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Categories_lbl.ForeColor = Color.DarkOliveGreen;
            Categories_lbl.Location = new Point(122, 521);
            Categories_lbl.Name = "Categories_lbl";
            Categories_lbl.Size = new Size(214, 27);
            Categories_lbl.TabIndex = 24;
            Categories_lbl.Text = "Product Categories";
            // 
            // Categories
            // 
            Categories.BackColor = Color.FromArgb(239, 236, 229);
            Categories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categories.ForeColor = Color.FromArgb(64, 51, 35);
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(365, 521);
            Categories.Name = "Categories";
            Categories.Size = new Size(191, 144);
            Categories.TabIndex = 23;
            // 
            // Image_txt
            // 
            Image_txt.BackColor = Color.FromArgb(239, 236, 229);
            Image_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Image_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Image_txt.Location = new Point(365, 439);
            Image_txt.Name = "Image_txt";
            Image_txt.Size = new Size(191, 31);
            Image_txt.TabIndex = 22;
            // 
            // Browse_btn
            // 
            Browse_btn.BackColor = Color.FromArgb(239, 236, 229);
            Browse_btn.FlatAppearance.BorderSize = 0;
            Browse_btn.FlatStyle = FlatStyle.Flat;
            Browse_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Browse_btn.ForeColor = Color.DarkOliveGreen;
            Browse_btn.Location = new Point(630, 431);
            Browse_btn.Name = "Browse_btn";
            Browse_btn.Size = new Size(115, 44);
            Browse_btn.TabIndex = 21;
            Browse_btn.Text = "Browse";
            Browse_btn.UseVisualStyleBackColor = true;
            Browse_btn.Click += Browse_btn_Click;
            // 
            // Image_lbl
            // 
            Image_lbl.AutoSize = true;
            Image_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Image_lbl.ForeColor = Color.DarkOliveGreen;
            Image_lbl.Location = new Point(122, 443);
            Image_lbl.Name = "Image_lbl";
            Image_lbl.Size = new Size(166, 27);
            Image_lbl.TabIndex = 20;
            Image_lbl.Text = "Product Image";
            // 
            // stock_txt
            // 
            stock_txt.BackColor = Color.FromArgb(239, 236, 229);
            stock_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stock_txt.ForeColor = Color.FromArgb(64, 51, 35);
            stock_txt.Location = new Point(365, 359);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(191, 31);
            stock_txt.TabIndex = 19;
            // 
            // Stock_lbl
            // 
            Stock_lbl.AutoSize = true;
            Stock_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Stock_lbl.ForeColor = Color.DarkOliveGreen;
            Stock_lbl.Location = new Point(122, 363);
            Stock_lbl.Name = "Stock_lbl";
            Stock_lbl.Size = new Size(159, 27);
            Stock_lbl.TabIndex = 18;
            Stock_lbl.Text = "Product Stock";
            // 
            // price_txt
            // 
            price_txt.BackColor = Color.FromArgb(239, 236, 229);
            price_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_txt.ForeColor = Color.FromArgb(64, 51, 35);
            price_txt.Location = new Point(365, 284);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(191, 31);
            price_txt.TabIndex = 17;
            // 
            // Price_lbl
            // 
            Price_lbl.AutoSize = true;
            Price_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Price_lbl.ForeColor = Color.DarkOliveGreen;
            Price_lbl.Location = new Point(122, 288);
            Price_lbl.Name = "Price_lbl";
            Price_lbl.Size = new Size(151, 27);
            Price_lbl.TabIndex = 16;
            Price_lbl.Text = "Product Price";
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Name_lbl.ForeColor = Color.DarkOliveGreen;
            Name_lbl.Location = new Point(122, 144);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(181, 27);
            Name_lbl.TabIndex = 15;
            Name_lbl.Text = "Choose Product";
            Name_lbl.Click += Name_lbl_Click;
            // 
            // Product_CB
            // 
            Product_CB.BackColor = Color.FromArgb(239, 236, 229);
            Product_CB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product_CB.ForeColor = Color.FromArgb(64, 51, 35);
            Product_CB.FormattingEnabled = true;
            Product_CB.Location = new Point(365, 144);
            Product_CB.Name = "Product_CB";
            Product_CB.Size = new Size(191, 33);
            Product_CB.TabIndex = 26;
            Product_CB.SelectedIndexChanged += Product_CB_SelectedIndexChanged;
            // 
            // PName_lbl
            // 
            PName_lbl.AutoSize = true;
            PName_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            PName_lbl.ForeColor = Color.DarkOliveGreen;
            PName_lbl.Location = new Point(122, 214);
            PName_lbl.Name = "PName_lbl";
            PName_lbl.Size = new Size(162, 27);
            PName_lbl.TabIndex = 27;
            PName_lbl.Text = "Product Name";
            // 
            // Name_txt
            // 
            Name_txt.BackColor = Color.FromArgb(239, 236, 229);
            Name_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Name_txt.Location = new Point(365, 210);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(191, 31);
            Name_txt.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(89, 9);
            label3.Name = "label3";
            label3.Size = new Size(588, 87);
            label3.TabIndex = 44;
            label3.Text = "Update Product";
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(942, 962);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(Name_txt);
            Controls.Add(PName_lbl);
            Controls.Add(Product_CB);
            Controls.Add(updateproduct_btn);
            Controls.Add(Categories_lbl);
            Controls.Add(Categories);
            Controls.Add(Image_txt);
            Controls.Add(Browse_btn);
            Controls.Add(Image_lbl);
            Controls.Add(stock_txt);
            Controls.Add(Stock_lbl);
            Controls.Add(price_txt);
            Controls.Add(Price_lbl);
            Controls.Add(Name_lbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateProduct";
            Text = "Oasis";
            FormClosing += UpdateProduct_FormClosing;
            Load += UpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateproduct_btn;
        private Label Categories_lbl;
        private CheckedListBox Categories;
        private TextBox Image_txt;
        private Button Browse_btn;
        private Label Image_lbl;
        private TextBox stock_txt;
        private Label Stock_lbl;
        private TextBox price_txt;
        private Label Price_lbl;
        private Label Name_lbl;
        private ComboBox Product_CB;
        private Label PName_lbl;
        private TextBox Name_txt;
        private PictureBox pictureBox1;
        private Label label3;
    }
}