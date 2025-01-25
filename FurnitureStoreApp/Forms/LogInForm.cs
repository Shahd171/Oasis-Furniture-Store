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
    public partial class LogInForm : Form
    {
        FurnitureStoreContext context = new FurnitureStoreContext();
        public User LoggedInUser { get; private set; }
        public LogInForm()
        {
            InitializeComponent();
        }




        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (email_txt.Text.Length > 0)
            {
                var admin = context.Users.Where(u => u.Role == "Admin" && u.Email == email_txt.Text && u.Password == password_txt.Text).FirstOrDefault();
                if (admin != null)
                {

                    AdminDashboard adminMenu = new AdminDashboard();
                    this.Hide();
                    adminMenu.ShowDialog();
                }
                else
                {
                    LoggedInUser = context.Users.Where(u => u.Role == "Customer" && u.Email == email_txt.Text && u.Password == password_txt.Text).FirstOrDefault();
                    if (LoggedInUser != null)
                    {
                        MessageBox.Show($"Welcome, {LoggedInUser.Name}!");
                        CustomerDashboard dashboard = new CustomerDashboard(LoggedInUser);

                        this.Hide();
                        dashboard.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {



            Application.Exit();


        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SignupForm signup = new SignupForm();
            this.Hide();
            signup.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Welcome = new WelcomeForm();
            this.Hide();
            Welcome.ShowDialog();
        }
    }
}
