using FurnitureStoreApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FurnitureStoreApp.Forms
{
    public partial class UpdateUser : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();

        public UpdateUser()
        {
            InitializeComponent();

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            LoadUsersIntoComboBox();
            List<string> l = new List<string>();
            l.AddRange(new string[] { "Admin", "Customer" });
            Role_CB.DataSource = l;

        }

        private void UpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void LoadUsersIntoComboBox()
        {
            // Assuming 'context' is your DbContext instance
            var users = context.Users.Select(u => new { u.UserID, u.Name, u.Email }).ToList();

            UserID_CB.DataSource = users;
            UserID_CB.DisplayMember = "Email";
            UserID_CB.ValueMember = "UserID";
        }

       

        private void updateUser_btn_Click(object sender, EventArgs e)
        {
            if (UserID_CB.SelectedValue == null)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }
            int selectedUserId = (int)UserID_CB.SelectedValue;


            var userToUpdate = context.Users.FirstOrDefault(u => u.UserID == selectedUserId);

            if (userToUpdate != null)
            {
                // Update user details
                userToUpdate.Name = Name_txt.Text;
                userToUpdate.Email = email_txt.Text;
                userToUpdate.Password = Password_txt.Text;
                userToUpdate.Role = Role_CB.SelectedItem.ToString();

                // Save changes to the database
                context.SaveChanges();

                MessageBox.Show("User updated successfully!");

                // Optionally refresh ComboBox and clear input fields
                LoadUsersIntoComboBox();
                ClearFields();
            }
            else
            {
                MessageBox.Show("User not found.");
            }


        }
        private void ClearFields()
        {
            Name_txt.Text = "";
            email_txt.Text = "";
            Password_txt.Text = "";
            Role_CB.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Admin = new AdminDashboard();
            this.Hide();
            Admin.ShowDialog();
        }

        private void UserID_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserID_CB.SelectedValue == null || !(UserID_CB.SelectedValue is int selectedUserId))
            {
                return; 
            }

           
            var selectedUser = context.Users.FirstOrDefault(u => u.UserID == selectedUserId);

            if (selectedUser != null)
            {
               
                Name_txt.Text = selectedUser.Name;
                email_txt.Text = selectedUser.Email;
                Password_txt.Text = selectedUser.Password;
                Role_CB.SelectedItem = selectedUser.Role;
            }
        }
    }
}
