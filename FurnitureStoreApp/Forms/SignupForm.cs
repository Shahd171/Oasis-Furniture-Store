using FurnitureStoreApp.Data;
using FurnitureStoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Networking;

namespace FurnitureStoreApp.Forms
{
    public partial class SignupForm : Form
    {
        private FurnitureStoreContext Context = new FurnitureStoreContext();

        public SignupForm()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            ResetErrorLabels();
            string Name = Name_txt.Text;
            string email = email_txt.Text;
            string password = password_txt.Text;
            string confirmPassword = confirmpass_txt.Text;
            bool isValid = ValidateInputs(Name, email, password, confirmPassword);

            if (!isValid)
                return; // If validation fails, stop further execution.

            // Check if email already exists
            if (Context.Users.Any(u => u.Email == email))
            {
                ShowError("emailErrorLabel", "Email is already registered.");
                return;
            }
            // Create a new user object
            var newUser = new User
            {
                Name = Name,
                Role = "Customer",
                Email = email,
                Password = password
            };

            // Save to database
            Context.Users.Add(newUser);
            Context.SaveChanges();

            MessageBox.Show("Sign-Up Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to Login Form
            this.Hide();
            LogInForm loginForm = new LogInForm();
            loginForm.ShowDialog();


        }
        private bool ValidateInputs(string Name, string email, string password, string confirmPassword)
        {
            bool isValid = true;

            // Name validation
            if (string.IsNullOrWhiteSpace(Name))
            {
                ShowError("NameErrorLabel", "Name is required.");
                isValid = false;
            }


            // Email validation
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowError("emailErrorLabel", "Email is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ShowError("emailErrorLabel", "Invalid email format.");
                isValid = false;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("passwordErrorLabel", "Password is required.");
                isValid = false;
            }
            else if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"[a-z]") ||
                     !Regex.IsMatch(password, @"\d") || !Regex.IsMatch(password, @"[@$!%*?&#]"))
            {
                ShowError("passwordErrorLabel", "Password must be at least 8 characters \n, include uppercase, lowercase, \n numbers, and special characters.");
                isValid = false;
            }

            // Confirm Password validation
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                ShowError("confirmPwErrorLabel", "Confirm Password is required.");
                isValid = false;
            }
            else if (password != confirmPassword)
            {
                ShowError("confirmPwErrorLabel", "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }
        private void ShowError(string labelName, string errorMessage)
        {
            Label errorLabel = this.Controls[labelName] as Label;
            if (errorLabel != null)
            {
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
            }
        }
        private void ResetErrorLabels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.EndsWith("ErrorLabel"))
                {
                    label.Text = "";
                    label.Visible = false;
                }
            }
        }



        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void emailErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void confirmPwErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Welcome = new WelcomeForm();
            this.Hide();
            Welcome.ShowDialog();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }



}
