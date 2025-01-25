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
    public partial class CustomerDashboard : Form
    {
        FurnitureStoreContext Context = new FurnitureStoreContext();

        private readonly User LoggedInUser;
        public CustomerDashboard(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


            LoadProducts(Context.Products.ToList());
            LoadCategories();

        }
        public void LoadProducts(List<Product> products)
        {

            // var products = Context.Products.ToList();
            ClearProductCards();
            foreach (var product in products)
            {
                // Create a new ProductCard
                var productCard = new ProductCard(product.ProductID);

                // Set product details
                productCard.SetProductDetails(product.Name, product.Price, product.ImagePath);

                productCard.AddToCartClicked += ProductCard_AddToCartClicked;
                // Add to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productCard);

            }

        }
        private void ProductCard_AddToCartClicked(object sender, int productId)
        {
            if (LoggedInUser == null)
            {
                MessageBox.Show("Please log in to add products to your cart.");
                return;
            }
            if (Context.Products == null)
            {
                MessageBox.Show("No products available.");
                return;
            }

            // Get or create the current order for the logged-in user
            var existingOrder = GetOrCreateOrder();

            // Find the product to add
            var product = Context.Products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            // Check if the stock is available
            if (product.StockQuantity <= 0)
            {
                MessageBox.Show("Sorry, this product is out of stock.");
                return;
            }

            // Check if the product is already in the order (cart)
            var existingOrderItem = existingOrder.OrderItems.FirstOrDefault(oi => oi.ProductID == productId);
            if (existingOrderItem != null)
            {
                // If product is already in cart, increase the quantity
                existingOrderItem.Quantity++;
            }
            else
            {
                // Add new product to the cart (as a new order item)
                var newOrderItem = new OrderItem
                {
                    ProductID = productId,
                    Quantity = 1
                };
                existingOrder.OrderItems.Add(newOrderItem);
            }

            // Decrease the stock quantity for the product in the database
            product.StockQuantity--;

            // Save changes to the database
            Context.SaveChanges();

            MessageBox.Show("Product added to cart.");

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Category_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchProduct_Click(object sender, EventArgs e)
        {

            var search = searchtxt.Text;
            ClearProductCards();


            var filteredE = Context.Products.Where(p => p.Name.Contains(search)).ToList();
            if (filteredE.Any())
            {
                LoadProducts(filteredE);
            }
            else
            {
                MessageBox.Show("No products found.");
            }
        }

        private void showCart_btn_Click(object sender, EventArgs e)
        {
            if (LoggedInUser != null)
            {
                CartForm cart = new CartForm(LoggedInUser);
                this.Hide();
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please log in to view your cart.");
                return;
            }
        }
        private void filtercategory_btn_Click(object sender, EventArgs e)
        {
            if (Category_CB.SelectedValue != null)
            {
                int selectedCategoryId = (int)Category_CB.SelectedValue;
                ClearProductCards();
                var products = Context.Products
                    .Where(p => p.Categories.Any(c => c.CategoryID == selectedCategoryId)).ToList();

                if (products.Any())
                {
                    LoadProducts(products);
                }
                else
                {
                    MessageBox.Show("No products found for the selected category.");
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }
        private void LoadCategories()
        {
            Category_CB.DataSource = Context.Categories.Select(c => new { c.CategoryID, c.Name }).ToList();
            Category_CB.DisplayMember = "Name";
            Category_CB.ValueMember = "CategoryID";
        }
        private void ClearProductCards()
        {
            // Collect controls to remove (to avoid modifying the collection while iterating)
            var controlsToRemove = flowLayoutPanel1.Controls
                .OfType<ProductCard>()
                .ToList();

            // Remove each product card
            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel1.Controls.Remove(control);
            }
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            var products = Context.Products.ToList();
            LoadProducts(products);

        }
        private Order GetOrCreateOrder()
        {
            // Try to find an open order for the logged-in user
            var existingOrder = Context.Orders
                .FirstOrDefault(o => o.UserID == LoggedInUser.UserID && o.TotalPrice == 0); // Order is not confirmed yet

            // If no open order exists, create a new one
            if (existingOrder == null)
            {
                existingOrder = new Order
                {
                    UserID = LoggedInUser.UserID,
                    OrderDate = DateTime.Now,
                    TotalPrice = 0,
                    OrderItems = new List<OrderItem>()
                };
                Context.Orders.Add(existingOrder);
                Context.SaveChanges();
            }

            return existingOrder;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Welcome = new WelcomeForm();
            this.Hide();
            Welcome.ShowDialog();
        }
    }
}
