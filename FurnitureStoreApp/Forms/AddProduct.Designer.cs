namespace FurnitureStoreApp.Forms
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            Name_txt = new TextBox();
            Name_lbl = new Label();
            Price_lbl = new Label();
            price_txt = new TextBox();
            Stock_lbl = new Label();
            stock_txt = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            Browse_btn = new Button();
            Image_txt = new TextBox();
            Categories = new CheckedListBox();
            label2 = new Label();
            addproduct_btn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Name_txt
            // 
            Name_txt.BackColor = Color.FromArgb(239, 236, 229);
            Name_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Name_txt.Location = new Point(346, 152);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(191, 31);
            Name_txt.TabIndex = 0;
            Name_txt.TextChanged += textBox1_TextChanged;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Name_lbl.ForeColor = Color.DarkOliveGreen;
            Name_lbl.Location = new Point(112, 152);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(162, 27);
            Name_lbl.TabIndex = 1;
            Name_lbl.Text = "Product Name";
            // 
            // Price_lbl
            // 
            Price_lbl.AutoSize = true;
            Price_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Price_lbl.ForeColor = Color.DarkOliveGreen;
            Price_lbl.Location = new Point(112, 227);
            Price_lbl.Name = "Price_lbl";
            Price_lbl.Size = new Size(151, 27);
            Price_lbl.TabIndex = 2;
            Price_lbl.Text = "Product Price";
            // 
            // price_txt
            // 
            price_txt.BackColor = Color.FromArgb(239, 236, 229);
            price_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_txt.ForeColor = Color.FromArgb(64, 51, 35);
            price_txt.Location = new Point(346, 223);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(191, 31);
            price_txt.TabIndex = 3;
            // 
            // Stock_lbl
            // 
            Stock_lbl.AutoSize = true;
            Stock_lbl.Font = new Font("Lucida Sans Unicode", 11F);
            Stock_lbl.ForeColor = Color.DarkOliveGreen;
            Stock_lbl.Location = new Point(114, 308);
            Stock_lbl.Name = "Stock_lbl";
            Stock_lbl.Size = new Size(159, 27);
            Stock_lbl.TabIndex = 4;
            Stock_lbl.Text = "Product Stock";
            // 
            // stock_txt
            // 
            stock_txt.BackColor = Color.FromArgb(239, 236, 229);
            stock_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stock_txt.ForeColor = Color.FromArgb(64, 51, 35);
            stock_txt.Location = new Point(346, 308);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(191, 31);
            stock_txt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11F);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(115, 387);
            label1.Name = "label1";
            label1.Size = new Size(166, 27);
            label1.TabIndex = 6;
            label1.Text = "Product Image";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.ShowPreview = true;
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Browse_btn
            // 
            Browse_btn.BackColor = Color.FromArgb(239, 236, 229);
            Browse_btn.FlatAppearance.BorderSize = 0;
            Browse_btn.FlatStyle = FlatStyle.Flat;
            Browse_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Browse_btn.ForeColor = Color.DarkOliveGreen;
            Browse_btn.Location = new Point(601, 378);
            Browse_btn.Name = "Browse_btn";
            Browse_btn.Size = new Size(115, 44);
            Browse_btn.TabIndex = 9;
            Browse_btn.Text = "Browse";
            Browse_btn.UseVisualStyleBackColor = true;
            Browse_btn.Click += Browse_btn_Click;
            // 
            // Image_txt
            // 
            Image_txt.BackColor = Color.FromArgb(239, 236, 229);
            Image_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Image_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Image_txt.Location = new Point(346, 387);
            Image_txt.Name = "Image_txt";
            Image_txt.Size = new Size(191, 31);
            Image_txt.TabIndex = 10;
            // 
            // Categories
            // 
            Categories.BackColor = Color.FromArgb(239, 236, 229);
            Categories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categories.ForeColor = Color.FromArgb(64, 51, 35);
            Categories.FormattingEnabled = true;
            Categories.Location = new Point(346, 452);
            Categories.Name = "Categories";
            Categories.Size = new Size(191, 144);
            Categories.TabIndex = 11;
            Categories.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11F);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(112, 452);
            label2.Name = "label2";
            label2.Size = new Size(214, 27);
            label2.TabIndex = 12;
            label2.Text = "Product Categories";
            // 
            // addproduct_btn
            // 
            addproduct_btn.FlatAppearance.BorderSize = 2;
            addproduct_btn.FlatStyle = FlatStyle.Flat;
            addproduct_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addproduct_btn.ForeColor = Color.DarkOliveGreen;
            addproduct_btn.Location = new Point(674, 557);
            addproduct_btn.Name = "addproduct_btn";
            addproduct_btn.Size = new Size(196, 64);
            addproduct_btn.TabIndex = 13;
            addproduct_btn.Text = "Add";
            addproduct_btn.UseVisualStyleBackColor = false;
            addproduct_btn.Click += addproduct_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(81, 22);
            label3.Name = "label3";
            label3.Size = new Size(478, 87);
            label3.TabIndex = 14;
            label3.Text = "Add Product";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(930, 693);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(addproduct_btn);
            Controls.Add(label2);
            Controls.Add(Categories);
            Controls.Add(Image_txt);
            Controls.Add(Browse_btn);
            Controls.Add(label1);
            Controls.Add(stock_txt);
            Controls.Add(Stock_lbl);
            Controls.Add(price_txt);
            Controls.Add(Price_lbl);
            Controls.Add(Name_lbl);
            Controls.Add(Name_txt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProduct";
            Text = "Oasis";
            FormClosing += AddProduct_FormClosing_1;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name_txt;
        private Label Name_lbl;
        private Label Price_lbl;
        private TextBox price_txt;
        private Label Stock_lbl;
        private TextBox stock_txt;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button Browse_btn;
        private TextBox Image_txt;
        private CheckedListBox Categories;
        private Label label2;
        private Button addproduct_btn;
        private Label label3;
        private PictureBox pictureBox1;
    }
}