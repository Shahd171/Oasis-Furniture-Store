
using FurnitureStoreApp.Data;
using FurnitureStoreApp.Forms;
using FurnitureStoreApp.Models;

namespace FurnitureStoreApp

{

    public partial class WelcomeForm : Form
    {
        private User LoggedInUser;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void shop_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard(LoggedInUser);
            this.Hide();
            dashboard.ShowDialog();
            //dashboard.LoadProducts();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.ShowDialog();
            LoggedInUser = logInForm.LoggedInUser;
            if (logInForm.LoggedInUser != null)
            {
                MessageBox.Show($"You are logged in as {LoggedInUser.Name}");
            }
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
