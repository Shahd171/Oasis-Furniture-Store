using System.Windows.Forms;

namespace FurnitureStoreApp.Forms
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            cartDataGridView = new DataGridView();
            remove_btn = new Button();
            Confirm_btn = new Button();
            totalPriceLabel = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cartDataGridView
            // 
            cartDataGridView.BackgroundColor = Color.FromArgb(180, 196, 180);
            cartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartDataGridView.GridColor = Color.FromArgb(180, 196, 180);
            cartDataGridView.Location = new Point(45, 158);
            cartDataGridView.Name = "cartDataGridView";
            cartDataGridView.RowHeadersWidth = 62;
            cartDataGridView.Size = new Size(1084, 317);
            cartDataGridView.TabIndex = 18;
            // 
            // remove_btn
            // 
            remove_btn.FlatAppearance.BorderSize = 2;
            remove_btn.FlatStyle = FlatStyle.Flat;
            remove_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_btn.ForeColor = Color.DarkOliveGreen;
            remove_btn.Location = new Point(45, 496);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(265, 67);
            remove_btn.TabIndex = 19;
            remove_btn.Text = "Remove from Cart";
            remove_btn.UseVisualStyleBackColor = false;
            remove_btn.Click += remove_btn_Click;
            // 
            // Confirm_btn
            // 
            Confirm_btn.FlatAppearance.BorderSize = 2;
            Confirm_btn.FlatStyle = FlatStyle.Flat;
            Confirm_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirm_btn.ForeColor = Color.DarkOliveGreen;
            Confirm_btn.Location = new Point(397, 498);
            Confirm_btn.Name = "Confirm_btn";
            Confirm_btn.Size = new Size(265, 67);
            Confirm_btn.TabIndex = 20;
            Confirm_btn.Text = "Confirm Order";
            Confirm_btn.UseVisualStyleBackColor = false;
            Confirm_btn.Click += Confirm_btn_Click;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Lucida Sans Unicode", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.ForeColor = Color.FromArgb(64, 51, 35);
            totalPriceLabel.Location = new Point(834, 498);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(0, 37);
            totalPriceLabel.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 36);
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
            label3.Location = new Point(100, 18);
            label3.Name = "label3";
            label3.Size = new Size(378, 87);
            label3.TabIndex = 48;
            label3.Text = "Your Cart";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(1216, 636);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(totalPriceLabel);
            Controls.Add(Confirm_btn);
            Controls.Add(remove_btn);
            Controls.Add(cartDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            Text = "Oasis";
            FormClosing += CartForm_FormClosing;
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cartDataGridView;
        private Button remove_btn;
        private Button Confirm_btn;
        private Label totalPriceLabel;
        private PictureBox pictureBox1;
        private Label label3;
    }
}