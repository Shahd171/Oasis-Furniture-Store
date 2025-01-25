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
using System.Security.Cryptography;


namespace FurnitureStoreApp.Forms
{
    public partial class AddUser : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();

        public AddUser()
        {
            InitializeComponent();
            List<string> l = new List<string>();
            l.AddRange(new string[] { "Admin", "Customer" });
            Role_CB.DataSource = l;

        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_txt.Text) ||
        string.IsNullOrEmpty(Password_txt.Text) ||
        string.IsNullOrEmpty(Role_CB.SelectedItem.ToString()))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            var newUser = new User
            {
                Name = Name_txt.Text,
                Password = Password_txt.Text,
                Role = Role_CB.SelectedItem.ToString(), // Admin or Customer
                Email = email_txt.Text,
            };

            // Save to the database
            context.Users.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("User added successfully!");
            ClearFields(); // Reset input fields
        }
        private void ClearFields()
        {
            Name_txt.Text = "";
            Password_txt.Text = "";
            email_txt.Text = "";
            Role_CB.SelectedIndex = -1; // Reset dropdown
        }
    

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Admin = new AdminDashboard();
            this.Hide();
            Admin.ShowDialog();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
