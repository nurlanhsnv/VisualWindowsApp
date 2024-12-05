using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualWindowsApp
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            eMail.Text = "Email";
            eMail.ForeColor = Color.LightGray;
        }

        private void eMail_Enter(object sender, EventArgs e)
        {
            if (eMail.Text == "Email")
            {
                eMail.Text = "";
                eMail.ForeColor = Color.Black;
            }
        }

        private void eMail_Leave(object sender, EventArgs e)
        {
            if(eMail.Text == "")
            {
                eMail.Text = "Email";
                eMail.ForeColor = Color.LightGray;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string input = eMail.Text.Trim();
            bool isfalan= true;
            if (!string.IsNullOrEmpty(input) || input=="Email")
            {
                foreach(var a in DataClass.Users)
                {
                    if (a.Email == input)
                    {
                        MessageBox.Show("Your password is " + a.Password);
                        isfalan = false;
                        break;
                    }
                   
                }

                if (isfalan)
                { MessageBox.Show("Email does not exist."); }
                
            }
        }
    }
}
