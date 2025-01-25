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
    public partial class CartForm : Form
    {
        private readonly FurnitureStoreContext Context = new FurnitureStoreContext();
        private readonly User LoggedInUser;
        public CartForm(User loggedInUser)
        {

            InitializeComponent();
            LoggedInUser = loggedInUser;

        }

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadCartItems()
        {
            if (LoggedInUser == null)
            {
                MessageBox.Show("Please log in to view your cart.");
                return;
            }

            // Get the current order for the user
            var order = Context.Orders
                .Where(o => o.UserID == LoggedInUser.UserID && o.TotalPrice == 0)
                .Select(o => new
                {
                    o.OrderID,
                    Items = o.OrderItems.Select(oi => new
                    {
                        oi.Product.Name,
                        oi.Product.Price,
                        oi.Quantity,
                        Subtotal = oi.Product.Price * oi.Quantity,
                        oi.ProductID
                    }).ToList()
                })
                .FirstOrDefault();

            if (order == null || !order.Items.Any())
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            // Bind the items to the DataGridView
            cartDataGridView.DataSource = order.Items;

            // Display the total price
            decimal totalPrice = order.Items.Sum(i => i.Subtotal);
            totalPriceLabel.Text = $"Total Price: {totalPrice:C2}";
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCartItems();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            var order = Context.Orders
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.Product)
            .FirstOrDefault(o => o.UserID == LoggedInUser.UserID && o.TotalPrice == 0);

            if (order == null || order.OrderItems == null || !order.OrderItems.Any())
            {
                cartDataGridView.DataSource = null; // Clear the cart view
                MessageBox.Show("Your cart is empty.");
                return;
            }

            // Load cart items into the view
            var cartItems = order.OrderItems.Select(oi => new
            {
                ProductName = oi.Product.Name,
              
                oi.Product.Price,
                Quantity = oi.Quantity,
               
                Subtotal = oi.Product.Price * oi.Quantity,
                oi.ProductID
            }).ToList();

            cartDataGridView.DataSource = cartItems;
            MessageBox.Show("Your order has been successfully placed");
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (cartDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected product ID
                int productId = (int)cartDataGridView.SelectedRows[0].Cells["ProductID"].Value;
                RemoveFromCart(productId);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void RemoveFromCart(int productId)
        {
            if (LoggedInUser == null)
            {
                MessageBox.Show("Please log in to modify your cart.");
                return;
            }

            // Get the open order
            var order = Context.Orders
     .Include(o => o.OrderItems) // Eagerly load OrderItems
     .ThenInclude(oi => oi.Product) // Eagerly load related Products
     .FirstOrDefault(o => o.UserID == LoggedInUser.UserID && o.TotalPrice == 0);

            if (order == null || order.OrderItems == null || !order.OrderItems.Any())
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            // Find the order item to remove
            var orderItem = order.OrderItems.FirstOrDefault(oi => oi.ProductID == productId);
            if (orderItem != null)
            {
                // Adjust stock back to the product
                var product = Context.Products.FirstOrDefault(p => p.ProductID == productId);
                if (product != null)
                {
                    product.StockQuantity += orderItem.Quantity;
                }

                // Remove the order item from the order
                order.OrderItems.Remove(orderItem);

                // Save changes to the database
                Context.SaveChanges();

                MessageBox.Show("Item removed from cart.");
            }
            else
            {
                MessageBox.Show("Item not found in the cart.");
            }

            LoadCartItems();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dashboard = new CustomerDashboard(LoggedInUser);
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
