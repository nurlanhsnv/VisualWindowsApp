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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';

            name.Text = "Name";
            userName.Text = "Username";
            password.Text = "Password";
            email.Text = "Email";
            phone.Text = "Phone";

            name.ForeColor= Color.LightGray;
            userName.ForeColor = Color.LightGray;
            password.ForeColor = Color.LightGray;
            email.ForeColor = Color.LightGray;
            phone.ForeColor = Color.LightGray;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Name")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text= "Name";
                name.ForeColor = Color.LightGray;
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Username")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Username";
                userName.ForeColor = Color.LightGray;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = Color.LightGray;
            }
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if (phone.Text == "Phone")
            {
                phone.Text = "";
                phone.ForeColor = Color.Black;
            }
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                phone.Text = "Phone";
                phone.ForeColor = Color.LightGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.LightGray;
            }
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
            if (button1.BackColor == Color.LightSeaGreen)
            {
                button1.BackColor = SystemColors.MenuHighlight;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n= name.Text.Trim();
            string uN=userName.Text.Trim();
            string eM=email.Text.Trim();
            string pass= password.Text.Trim();
            string rl = comboBox1.Text.Trim();
            string ph = phone.Text.Trim();
            bool isExist=false;
            foreach(var item in DataClass.Users)
            {
                if (item.Name==n && item.Username==uN && item.Email==eM && item.Password==pass && item.Role==rl && item.Phone==ph)
                {
                    isExist = true;
                    break;
                   
                }
            }
            if (isExist) 
            {
                     MessageBox.Show("This user is already exist");
            }
            else
            {
                DataClass.Users.Add(new UserEntity
                {
                    Name = n,
                    Username = uN,
                    Email = eM,
                    Password = pass,
                    Role = rl,
                    Phone = ph
                });

                MessageBox.Show("User added successfully.");
            }

        }
    }
}
