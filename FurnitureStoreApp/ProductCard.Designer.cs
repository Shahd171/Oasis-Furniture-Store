namespace FurnitureStoreApp
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PImage = new PictureBox();
            Name_lbl = new Label();
            Price_lbl = new Label();
            shop = new Button();
            ((System.ComponentModel.ISupportInitialize)PImage).BeginInit();
            SuspendLayout();
            // 
            // PImage
            // 
            PImage.Location = new Point(3, 23);
            PImage.Name = "PImage";
            PImage.Size = new Size(367, 181);
            PImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PImage.TabIndex = 0;
            PImage.TabStop = false;
            PImage.Click += PImage_Click;
            // 
            // Name_lbl
            // 
            Name_lbl.AutoSize = true;
            Name_lbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_lbl.ForeColor = Color.FromArgb(64, 51, 35);
            Name_lbl.Location = new Point(3, 227);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(57, 21);
            Name_lbl.TabIndex = 1;
            Name_lbl.Text = "label1";
            Name_lbl.Click += label1_Click;
            // 
            // Price_lbl
            // 
            Price_lbl.AutoSize = true;
            Price_lbl.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price_lbl.ForeColor = Color.FromArgb(64, 51, 35);
            Price_lbl.Location = new Point(262, 227);
            Price_lbl.Name = "Price_lbl";
            Price_lbl.Size = new Size(57, 21);
            Price_lbl.TabIndex = 2;
            Price_lbl.Text = "label2";
            Price_lbl.Click += label2_Click;
            // 
            // shop
            // 
            shop.FlatAppearance.BorderSize = 0;
            shop.FlatStyle = FlatStyle.Flat;
            shop.Font = new Font("Lucida Sans Unicode", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shop.ForeColor = Color.DarkOliveGreen;
            shop.Location = new Point(113, 216);
            shop.Name = "shop";
            shop.Size = new Size(143, 43);
            shop.TabIndex = 7;
            shop.Text = "Add To Cart";
            shop.UseVisualStyleBackColor = false;
            shop.Click += addCart_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(shop);
            Controls.Add(Price_lbl);
            Controls.Add(Name_lbl);
            Controls.Add(PImage);
            Name = "ProductCard";
            Size = new Size(373, 273);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)PImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PImage;
        private Label Name_lbl;
        private Label Price_lbl;
        private Button shop;
    }
}
