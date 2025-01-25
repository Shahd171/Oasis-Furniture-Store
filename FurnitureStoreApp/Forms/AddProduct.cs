using FurnitureStoreApp.Data;
using FurnitureStoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureStoreApp.Forms
{
    public partial class AddProduct : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();

        public AddProduct()
        {
            InitializeComponent();
        }
        private void AddProduct_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    Image_txt.Text = imagePath; // Display path in a TextBox

                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {

            var categories = context.Categories.ToList();

            // Clear existing items
            Categories.Items.Clear();

            // Add categories to the CheckedListBox
            foreach (var category in categories)
            {
                Categories.Items.Add(category.Name, false);
            }

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {

            var name = Name_txt.Text;

            var price = decimal.Parse(price_txt.Text);
            var stock = int.Parse(stock_txt.Text);
            var path = Image_txt.Text;
            var categories = Categories.CheckedItems;
            List<Category> c = new List<Category>();
            foreach (var category in categories)
            {
                Category item = new Category
                {
                    CategoryID = context.Categories.Where(i => i.Name == category).
                    Select(i => i.CategoryID).FirstOrDefault(),
                    Name = category.ToString()
                };
                c.Add(item);
            }
            Product p = new Product { Name = name, Price = price, StockQuantity = stock, ImagePath = path };
            context.Products.Add(p);


            context.SaveChanges();
            int id = p.ProductID;
            var productCategories = c.Select(category => new ProductsCategories
            {
                CategoryID = category.CategoryID,
                ProductID = id
            }).ToList();

            context.ProductsCategories.AddRange(productCategories);

            context.SaveChanges();
            MessageBox.Show($"Product Added Successfully");
            Name_txt.Text = string.Empty;

            price_txt.Text = string.Empty;
            stock_txt.Text = string.Empty;
            Image_txt.Text = string.Empty;
            for (int x = 0; x < Categories.Items.Count; x++)
            {
                Categories.SetItemChecked(x, false);
            }
            //LoadProducts();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Admin = new AdminDashboard();
            this.Hide();
            Admin.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
