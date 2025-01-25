using FurnitureStoreApp.Data;
using FurnitureStoreApp.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class UpdateProduct : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();

        public UpdateProduct()
        {
            InitializeComponent();

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
        private void LoadProducts()
        {
            Product_CB.DataSource = context.Products.Select(p => new { p.ProductID, p.Name }).ToList();
            Product_CB.DisplayMember = "Name";
            Product_CB.ValueMember = "ProductID";
        }

        private void UpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

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

        private void updateproduct_btn_Click(object sender, EventArgs e)
        {
            int id = (int)Product_CB.SelectedValue;
            var name = Name_txt.Text;
            var price = decimal.Parse(price_txt.Text);
            var stock = int.Parse(stock_txt.Text);
            var path = Image_txt.Text;
            var categories = Categories.CheckedItems;

            // Detach any existing instance of the Product entity
            var trackedEntity = context.ChangeTracker.Entries<Product>()
                .FirstOrDefault(e => e.Entity.ProductID == id);
            if (trackedEntity != null)
            {
                context.Entry(trackedEntity.Entity).State = EntityState.Detached;
            }
            var existingProduct = context.Products
      .Include(p => p.Categories) // Ensure Categories relationship is loaded
      .FirstOrDefault(p => p.ProductID == id);

            if (existingProduct == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }
            existingProduct.Name = name;
            existingProduct.Price = price;
            existingProduct.StockQuantity = stock;
            existingProduct.ImagePath = path;

            // Update categories (clear old ones and add new ones)
            existingProduct.Categories.Clear();

            foreach (var category in categories)
            {
                var categoryName = category.ToString();
                var existingCategory = context.Categories.FirstOrDefault(c => c.Name == categoryName);

                if (existingCategory != null)
                {
                    var productCategory = new ProductsCategories
                    {
                        ProductID = id,
                        CategoryID = existingCategory.CategoryID
                    };

                    existingProduct.Categories.Add(productCategory);
                }
            }

            // Save changes to the database
            context.SaveChanges();

            // Notify the user and refresh UI
            MessageBox.Show($"Product Updated Successfully");

            // Clear input fields and reload data
            Name_txt.Text = string.Empty;
            price_txt.Text = string.Empty;
            stock_txt.Text = string.Empty;
            Image_txt.Text = string.Empty;

            for (int x = 0; x < Categories.Items.Count; x++)
            {
                Categories.SetItemChecked(x, false);
            }

            LoadProducts();
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

        private void Name_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Admin = new AdminDashboard();
            this.Hide();
            Admin.ShowDialog();
        }

        private void Product_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Product_CB.SelectedValue == null || !(Product_CB.SelectedValue is int selectedProductId))
            {
                return; // Exit if no valid product is selected
            }

            // Fetch the selected product details
            var selectedProduct = context.Products.Include(p => p.Categories)
                                                  .FirstOrDefault(p => p.ProductID == selectedProductId);

            if (selectedProduct != null)
            {
                // Populate the fields with product details
                Name_txt.Text = selectedProduct.Name;
                price_txt.Text = selectedProduct.Price.ToString();
                stock_txt.Text = selectedProduct.StockQuantity.ToString();
                Image_txt.Text = selectedProduct.ImagePath;

                // Check categories in the CheckedListBox
                for (int i = 0; i < Categories.Items.Count; i++)
                {
                    string categoryName = Categories.Items[i].ToString();
                    Categories.SetItemChecked(i, selectedProduct.Categories.Any(c => c.Category.Name == categoryName));
                }
            }
        
        }
    }
}
