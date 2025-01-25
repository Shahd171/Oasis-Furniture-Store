using System.Windows.Forms;

namespace FurnitureStoreApp.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            addproduct_btn = new Button();
            update_btn = new Button();
            remove_btn = new Button();
            dataGridView1 = new DataGridView();
            Searchname_btn = new Button();
            searchtxt = new TextBox();
            filtercategory_btn = new Button();
            Category_CB = new ComboBox();
            delete_txt = new TextBox();
            Products_lbl = new Label();
            Customers_lbl = new Label();
            dataGridView2 = new DataGridView();
            delete_usertxt = new TextBox();
            Roles_CB = new ComboBox();
            button1 = new Button();
            search_usertxt = new TextBox();
            Search_Users = new Button();
            removeuser_btn = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            category_lbl = new Label();
            Category_txt = new TextBox();
            AddCategory_btn = new Button();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // addproduct_btn
            // 
            addproduct_btn.FlatStyle = FlatStyle.Flat;
            addproduct_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addproduct_btn.ForeColor = Color.DarkOliveGreen;
            addproduct_btn.Location = new Point(625, 252);
            addproduct_btn.Name = "addproduct_btn";
            addproduct_btn.Size = new Size(205, 56);
            addproduct_btn.TabIndex = 14;
            addproduct_btn.Text = "Add Product";
            addproduct_btn.UseVisualStyleBackColor = false;
            addproduct_btn.Click += addproduct_btn_Click;
            // 
            // update_btn
            // 
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.DarkOliveGreen;
            update_btn.Location = new Point(896, 252);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(264, 56);
            update_btn.TabIndex = 15;
            update_btn.Text = "Update Product";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.FlatStyle = FlatStyle.Flat;
            remove_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove_btn.ForeColor = Color.DarkOliveGreen;
            remove_btn.Location = new Point(897, 186);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(264, 47);
            remove_btn.TabIndex = 16;
            remove_btn.Text = "Remove Product";
            remove_btn.UseVisualStyleBackColor = false;
            remove_btn.Click += remove_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(180, 196, 180);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(180, 196, 180);
            dataGridView1.Location = new Point(94, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(500, 244);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // Searchname_btn
            // 
            Searchname_btn.FlatStyle = FlatStyle.Flat;
            Searchname_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchname_btn.ForeColor = Color.DarkOliveGreen;
            Searchname_btn.Location = new Point(896, 51);
            Searchname_btn.Name = "Searchname_btn";
            Searchname_btn.Size = new Size(264, 54);
            Searchname_btn.TabIndex = 18;
            Searchname_btn.Text = "Search Product";
            Searchname_btn.UseVisualStyleBackColor = false;
            Searchname_btn.Click += searchProduct_Click;
            // 
            // searchtxt
            // 
            searchtxt.BackColor = Color.FromArgb(239, 236, 229);
            searchtxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchtxt.ForeColor = Color.FromArgb(64, 51, 35);
            searchtxt.Location = new Point(625, 64);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(205, 31);
            searchtxt.TabIndex = 19;
            // 
            // filtercategory_btn
            // 
            filtercategory_btn.FlatStyle = FlatStyle.Flat;
            filtercategory_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filtercategory_btn.ForeColor = Color.DarkOliveGreen;
            filtercategory_btn.Location = new Point(897, 117);
            filtercategory_btn.Name = "filtercategory_btn";
            filtercategory_btn.Size = new Size(264, 49);
            filtercategory_btn.TabIndex = 20;
            filtercategory_btn.Text = "Filter By Category";
            filtercategory_btn.UseVisualStyleBackColor = false;
            filtercategory_btn.Click += filtercategory_btn_Click;
            // 
            // Category_CB
            // 
            Category_CB.BackColor = Color.FromArgb(239, 236, 229);
            Category_CB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_CB.ForeColor = Color.FromArgb(64, 51, 35);
            Category_CB.FormattingEnabled = true;
            Category_CB.Location = new Point(625, 127);
            Category_CB.Name = "Category_CB";
            Category_CB.Size = new Size(205, 33);
            Category_CB.TabIndex = 21;
            // 
            // delete_txt
            // 
            delete_txt.BackColor = Color.FromArgb(239, 236, 229);
            delete_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_txt.ForeColor = Color.FromArgb(64, 51, 35);
            delete_txt.Location = new Point(625, 195);
            delete_txt.Name = "delete_txt";
            delete_txt.Size = new Size(205, 31);
            delete_txt.TabIndex = 22;
            // 
            // Products_lbl
            // 
            Products_lbl.AutoSize = true;
            Products_lbl.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Products_lbl.ForeColor = Color.DarkOliveGreen;
            Products_lbl.Location = new Point(94, 27);
            Products_lbl.Name = "Products_lbl";
            Products_lbl.Size = new Size(139, 34);
            Products_lbl.TabIndex = 23;
            Products_lbl.Text = "Products";
            // 
            // Customers_lbl
            // 
            Customers_lbl.AutoSize = true;
            Customers_lbl.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Customers_lbl.ForeColor = Color.DarkOliveGreen;
            Customers_lbl.Location = new Point(94, 336);
            Customers_lbl.Name = "Customers_lbl";
            Customers_lbl.Size = new Size(94, 34);
            Customers_lbl.TabIndex = 25;
            Customers_lbl.Text = "Users";
            Customers_lbl.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(180, 196, 180);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.FromArgb(180, 196, 180);
            dataGridView2.Location = new Point(94, 392);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(500, 240);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            // 
            // delete_usertxt
            // 
            delete_usertxt.BackColor = Color.FromArgb(239, 236, 229);
            delete_usertxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_usertxt.ForeColor = Color.FromArgb(64, 51, 35);
            delete_usertxt.Location = new Point(622, 511);
            delete_usertxt.Name = "delete_usertxt";
            delete_usertxt.Size = new Size(205, 31);
            delete_usertxt.TabIndex = 33;
            // 
            // Roles_CB
            // 
            Roles_CB.BackColor = Color.FromArgb(239, 236, 229);
            Roles_CB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Roles_CB.ForeColor = Color.FromArgb(64, 51, 35);
            Roles_CB.FormattingEnabled = true;
            Roles_CB.Location = new Point(622, 442);
            Roles_CB.Name = "Roles_CB";
            Roles_CB.Size = new Size(205, 33);
            Roles_CB.TabIndex = 32;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOliveGreen;
            button1.Location = new Point(893, 431);
            button1.Name = "button1";
            button1.Size = new Size(264, 51);
            button1.TabIndex = 31;
            button1.Text = "Filter By Role";
            button1.UseVisualStyleBackColor = false;
            button1.Click += filterByRole_Click;
            // 
            // search_usertxt
            // 
            search_usertxt.BackColor = Color.FromArgb(239, 236, 229);
            search_usertxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_usertxt.ForeColor = Color.FromArgb(64, 51, 35);
            search_usertxt.Location = new Point(622, 379);
            search_usertxt.Name = "search_usertxt";
            search_usertxt.Size = new Size(205, 31);
            search_usertxt.TabIndex = 30;
            // 
            // Search_Users
            // 
            Search_Users.FlatStyle = FlatStyle.Flat;
            Search_Users.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search_Users.ForeColor = Color.DarkOliveGreen;
            Search_Users.Location = new Point(892, 370);
            Search_Users.Name = "Search_Users";
            Search_Users.Size = new Size(265, 46);
            Search_Users.TabIndex = 29;
            Search_Users.Text = "Search Users";
            Search_Users.UseVisualStyleBackColor = false;
            Search_Users.Click += Search_Users_Click;
            // 
            // removeuser_btn
            // 
            removeuser_btn.FlatStyle = FlatStyle.Flat;
            removeuser_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeuser_btn.ForeColor = Color.DarkOliveGreen;
            removeuser_btn.Location = new Point(892, 498);
            removeuser_btn.Name = "removeuser_btn";
            removeuser_btn.Size = new Size(265, 55);
            removeuser_btn.TabIndex = 28;
            removeuser_btn.Text = "Remove User";
            removeuser_btn.UseVisualStyleBackColor = false;
            removeuser_btn.Click += removeuser_btn_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkOliveGreen;
            button4.Location = new Point(893, 563);
            button4.Name = "button4";
            button4.Size = new Size(265, 56);
            button4.TabIndex = 27;
            button4.Text = "Update User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += UpdateUser_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DarkOliveGreen;
            button5.Location = new Point(622, 563);
            button5.Name = "button5";
            button5.Size = new Size(205, 56);
            button5.TabIndex = 26;
            button5.Text = "Add User";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AddUser_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(category_lbl);
            panel1.Controls.Add(Category_txt);
            panel1.Controls.Add(AddCategory_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(Products_lbl);
            panel1.Controls.Add(delete_usertxt);
            panel1.Controls.Add(addproduct_btn);
            panel1.Controls.Add(Roles_CB);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(remove_btn);
            panel1.Controls.Add(search_usertxt);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(Search_Users);
            panel1.Controls.Add(Searchname_btn);
            panel1.Controls.Add(removeuser_btn);
            panel1.Controls.Add(searchtxt);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(filtercategory_btn);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Category_CB);
            panel1.Controls.Add(Customers_lbl);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(delete_txt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 1050);
            panel1.TabIndex = 34;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // category_lbl
            // 
            category_lbl.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_lbl.ForeColor = Color.DarkOliveGreen;
            category_lbl.Location = new Point(622, 785);
            category_lbl.Name = "category_lbl";
            category_lbl.Size = new Size(192, 35);
            category_lbl.TabIndex = 41;
            category_lbl.Text = "Category Name";
            // 
            // Category_txt
            // 
            Category_txt.BackColor = Color.FromArgb(239, 236, 229);
            Category_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_txt.ForeColor = Color.FromArgb(64, 51, 35);
            Category_txt.Location = new Point(894, 784);
            Category_txt.Name = "Category_txt";
            Category_txt.Size = new Size(264, 31);
            Category_txt.TabIndex = 40;
            // 
            // AddCategory_btn
            // 
            AddCategory_btn.FlatStyle = FlatStyle.Flat;
            AddCategory_btn.Font = new Font("Lucida Sans Unicode", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCategory_btn.ForeColor = Color.DarkOliveGreen;
            AddCategory_btn.Location = new Point(894, 837);
            AddCategory_btn.Name = "AddCategory_btn";
            AddCategory_btn.Size = new Size(266, 54);
            AddCategory_btn.TabIndex = 39;
            AddCategory_btn.Text = "Add Category";
            AddCategory_btn.UseVisualStyleBackColor = false;
            AddCategory_btn.Click += AddCategory_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(94, 653);
            label1.Name = "label1";
            label1.Size = new Size(168, 34);
            label1.TabIndex = 35;
            label1.Text = "Categories";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(180, 196, 180);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = Color.FromArgb(180, 196, 180);
            dataGridView3.Location = new Point(94, 712);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(500, 224);
            dataGridView3.TabIndex = 34;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 229);
            ClientSize = new Size(1211, 1050);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            Text = "Oasis";
            FormClosing += AdminMenu_FormClosing;
            Load += AdminMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addproduct_btn;
        private Button update_btn;
        private Button remove_btn;
        private DataGridView dataGridView1;
        private Button Searchname_btn;
        private TextBox searchtxt;
        private Button filtercategory_btn;
        private ComboBox Category_CB;
        private TextBox delete_txt;
        private Label Products_lbl;
        private Label Customers_lbl;
        private DataGridView dataGridView2;
        private TextBox delete_usertxt;
        private ComboBox Roles_CB;
        private Button button1;
        private TextBox search_usertxt;
        private Button Search_Users;
        private Button removeuser_btn;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private TextBox Category_txt;
        private Button AddCategory_btn;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private DataGridView dataGridView3;
        private Label category_lbl;
        private PictureBox pictureBox1;
    }
}