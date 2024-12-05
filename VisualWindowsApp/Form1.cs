using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualWindowsApp.Model;

namespace VisualWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

            txtName.Text = "Name";
            txtPassword.Text = "Password";
            txtName.ForeColor = Color.LightGray;
            txtPassword.ForeColor = Color.LightGray;     
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text=="Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                txtName.Text = "Name";
                txtName.ForeColor= Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        } 
        private void txtName_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAuthenticated = false;

            try
            {
                foreach (var item in DataClass.Users)
                {
                    if (txtName.Text == item.Username && txtPassword.Text == item.Password)
                    {
                        HomePageForm homePageForm = new HomePageForm();
                        homePageForm.Show();
                        this.Hide();
                        isAuthenticated = true;
                        break; 
                    }
                }

                if (!isAuthenticated)
                {
                    MessageBox.Show("Wrong username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm= new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (button1.BackColor == SystemColors.MenuHighlight) 
            {
                button1.BackColor = Color.LightSeaGreen;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.LightSeaGreen)
            {
                button1.BackColor = SystemColors.MenuHighlight;
            }
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm= new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}

