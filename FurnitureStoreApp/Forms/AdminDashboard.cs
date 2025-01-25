using FurnitureStoreApp.Data;
using FurnitureStoreApp.Models;
using System.Data;

namespace FurnitureStoreApp.Forms
{
    public partial class AdminDashboard : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();


        public AdminDashboard()
        {
            InitializeComponent();

        }





        private void addproduct_btn_Click(object sender, EventArgs e)
        {

            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            UpdateProduct updateProduct = new UpdateProduct();
            this.Hide();
            updateProduct.ShowDialog();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            FillView();
            LoadCategories();
            LoadRoles();
        }
        private void FillView()
        {


            dataGridView1.DataSource = context.Products
            .Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Price,
                p.StockQuantity,
                Categories = string.Join(", ", p.Categories.Select(c => c.Category.Name)) // Combine category names
            })
            .ToList();
            
            dataGridView2.DataSource = context.Users.Select(u => new
            {
                u.UserID,
                u.Name,
                u.Email,
                u.Role,
                OrdersCount = u.Orders.Count
            })
        .ToList();

            dataGridView3.DataSource = context.Categories.Select(c => new { c.CategoryID, c.Name }).ToList();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchProduct_Click(object sender, EventArgs e)
        {

            var search = searchtxt.Text;

            var filteredE = context.Products.Where(p => p.Name.Contains(search)).Select(p => new
            {
                p.ProductID,
                p.Name,
                p.Price,
                p.StockQuantity,
                Categories = string.Join(", ", p.Categories.Select(c => c.Category.Name)) // Combine category names
            })
        .ToList();
            dataGridView1.DataSource = filteredE;

        }

        private void filtercategory_btn_Click(object sender, EventArgs e)
        {
            if (Category_CB.SelectedValue != null)
            {
                int selectedCategoryId = (int)Category_CB.SelectedValue;
                dataGridView1.DataSource = context.Products
                    .Where(p => p.Categories.Any(c => c.CategoryID == selectedCategoryId))
                    .Select(p => new
                    {
                        p.ProductID,
                        p.Name,
                        p.Price,
                        p.StockQuantity,
                        Categories = string.Join(", ", p.Categories.Select(c => c.Category.Name))
                    })
                    .ToList();
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }
        private void LoadCategories()
        {
            Category_CB.DataSource = context.Categories.Select(c => new { c.CategoryID, c.Name }).ToList();
            Category_CB.DisplayMember = "Name";
            Category_CB.ValueMember = "CategoryID";
        }

        private void LoadRoles()
        {
           
            List<string> l = new List<string>();
            l.AddRange(new string[] { "Admin", "Customer" });
            Roles_CB.DataSource = l;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                delete_txt.Text = row.Cells["ProductID"].Value.ToString();

            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var productId = int.Parse(delete_txt.Text);
            Product p = context.Products.Find(productId);
            context.Products.Remove(p);
            context.SaveChanges();
            FillView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Users_Click(object sender, EventArgs e)
        {
            var search = search_usertxt.Text;

            var filteredE = context.Users.Where(u => u.Name.Contains(search)).Select(u => new
            {
                u.UserID,
                u.Name,
                u.Email,
                u.Role,
                OrdersCount = u.Orders.Count
            })
        .ToList();
            dataGridView2.DataSource = filteredE;
        }

        private void filterByRole_Click(object sender, EventArgs e)
        {
            string selectedRole = Roles_CB.SelectedValue.ToString();
            dataGridView2.DataSource = context.Users
                .Where(u => u.Role == selectedRole)
                .Select(u => new
                {
                    u.UserID,
                    u.Name,
                    u.Email,
                    u.Role,
                    OrdersCount = u.Orders.Count
                })
                .ToList();
        }

        private void removeuser_btn_Click(object sender, EventArgs e)
        {
            int UserId = int.Parse(delete_usertxt.Text);
            User user = context.Users.Find(UserId);
            context.Users.Remove(user);
            context.SaveChanges();
            FillView();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                delete_usertxt.Text = row.Cells["UserID"].Value.ToString();
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            this.Hide();
            addUser.ShowDialog();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            this.Hide();
            updateUser.ShowDialog();
         
        }

        private void AddCategory_btn_Click(object sender, EventArgs e)
        {
            var newCategory = new Category
            {
                Name = Category_txt.Text
            };

            context.Categories.Add(newCategory);
            context.SaveChanges();

            MessageBox.Show("Category added successfully!");
            LoadCategories();
            dataGridView3.DataSource = context.Categories.Select(c => new { c.CategoryID, c.Name }).ToList();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Login = new LogInForm();
            this.Hide();
            Login.ShowDialog();
        }
    }
}
