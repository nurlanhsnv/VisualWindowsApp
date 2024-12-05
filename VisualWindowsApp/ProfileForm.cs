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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }
        
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            label1.Text=DataClass.Users.First().Role;
            label2.Text=DataClass.Users.Last().Name;



            textName.Text=DataClass.Users.First().Name;
            textName.ForeColor = Color.LightGray;

            textEmail.Text=DataClass.Users.First().Email;
            textEmail.ForeColor = Color.LightGray;

            textPh.Text=DataClass.Users.First().Phone;
            textPh.ForeColor = Color.LightGray;

            textRole.Text=DataClass.Users.First().Role; textRole.ForeColor = Color.LightGray;

            textUname.Text=DataClass.Users.First().Username;
            textUname.ForeColor = Color.LightGray;

            textPass.Text = DataClass.Users.First().Password;
            textPass.ForeColor = Color.LightGray;
            textPass.PasswordChar = '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        bool isGray = true;
        private void editButton_Click(object sender, EventArgs e)
        {
            if (isGray)
            {
                textName.ForeColor = Color.Black;

                textEmail.ForeColor = Color.Black;

                textPh.ForeColor = Color.Black;

                textRole.ForeColor = Color.Black;

                textUname.ForeColor = Color.Black;

                textPass.ForeColor = Color.Black;
                isGray = false;
            }
            else
            {
                textName.ForeColor = Color.LightGray;

                textEmail.ForeColor = Color.LightGray;

                textPh.ForeColor = Color.LightGray;

                textRole.ForeColor = Color.LightGray;

                textUname.ForeColor = Color.LightGray;

                textPass.ForeColor = Color.LightGray;
                isGray = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hiddenEye_Click(object sender, EventArgs e)
        {
            string firstImagePath = @"C:\VisualPictures\hidden.png";
            string secondImagePath = @"C:\VisualPictures\eye.png";

            if (hiddenEye.ImageLocation == firstImagePath)
            {
                hiddenEye.ImageLocation = secondImagePath;
                textPass.PasswordChar = '\0';
            }
            else
            {
                hiddenEye.ImageLocation = firstImagePath; 
                textPass.PasswordChar = '*';

            }
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            sideT.Start();
        }
        bool sideBar=true;
        private void sideT_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                Point currentLocation = sideP.Location;
                currentLocation.X = 30;


                sidePanel.Width -= 50;
                if (sidePanel.Width <= 11)
                {
                    sideP.Location = currentLocation;
                    sideT.Stop();
                    sideBar = false;
                }
            }
            else
            {
                Point currentLocation = sideP.Location;
                currentLocation.X = 303;


                sidePanel.Width += 50;
                if (sidePanel.Width > 270)
                {
                    sideP.Location = currentLocation;
                    sideT.Stop();
                    sideBar = true;
                }
            }
        }

        private void dashboardButton_MouseEnter(object sender, EventArgs e)
        {
            if (dashboardButton.BackColor == Color.AliceBlue && dashboardButton.ForeColor == SystemColors.MenuHighlight)
            {
                dashboardButton.BackColor = Color.CornflowerBlue;
                dashboardButton.ForeColor = Color.White;
            }
        }

        private void dashboardButton_MouseLeave(object sender, EventArgs e)
        {
            if (dashboardButton.BackColor == Color.CornflowerBlue && dashboardButton.ForeColor == Color.White)
            {
                dashboardButton.BackColor = Color.AliceBlue;
                dashboardButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void productsButton_MouseEnter(object sender, EventArgs e)
        {
            if (productsButton.BackColor == Color.AliceBlue && productsButton.ForeColor == SystemColors.MenuHighlight)
            {
                productsButton.BackColor = Color.CornflowerBlue;
                productsButton.ForeColor = Color.White;
            }
        }

        private void productsButton_MouseLeave(object sender, EventArgs e)
        {
            if (productsButton.BackColor == Color.CornflowerBlue && productsButton.ForeColor == Color.White)
            {
                productsButton.BackColor = Color.AliceBlue;
                productsButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void tradingButton_MouseEnter(object sender, EventArgs e)
        {
            if (tradingButton.BackColor == Color.AliceBlue && tradingButton.ForeColor == SystemColors.MenuHighlight)
            {
                tradingButton.BackColor = Color.CornflowerBlue;
                tradingButton.ForeColor = Color.White;
            }
        }

        private void tradingButton_MouseLeave(object sender, EventArgs e)
        {
            if (tradingButton.BackColor == Color.CornflowerBlue && tradingButton.ForeColor == Color.White)
            {
                tradingButton.BackColor = Color.AliceBlue;
                tradingButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void expenseButton_MouseEnter(object sender, EventArgs e)
        {
            if (expenseButton.BackColor == Color.AliceBlue && expenseButton.ForeColor == SystemColors.MenuHighlight)
            {
                expenseButton.BackColor = Color.CornflowerBlue;
                expenseButton.ForeColor = Color.White;
            }
        }

        private void expenseButton_MouseLeave(object sender, EventArgs e)
        {
            if (expenseButton.BackColor == Color.CornflowerBlue && expenseButton.ForeColor == Color.White)
            {
                expenseButton.BackColor = Color.AliceBlue;
                expenseButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void reportButton_MouseEnter(object sender, EventArgs e)
        {
            if (reportButton.BackColor == Color.AliceBlue && reportButton.ForeColor == SystemColors.MenuHighlight)
            {
                reportButton.BackColor = Color.CornflowerBlue;
                reportButton.ForeColor = Color.White;
            }
        }

        private void reportButton_MouseLeave(object sender, EventArgs e)
        {
            if (reportButton.BackColor == Color.CornflowerBlue && reportButton.ForeColor == Color.White)
            {
                reportButton.BackColor = Color.AliceBlue;
                reportButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void transferButton_MouseEnter(object sender, EventArgs e)
        {
            if (transferButton.BackColor == Color.AliceBlue && transferButton.ForeColor == SystemColors.MenuHighlight)
            {
                transferButton.BackColor = Color.CornflowerBlue;
                transferButton.ForeColor = Color.White;
            }
        }

        private void transferButton_MouseLeave(object sender, EventArgs e)
        {
            if (transferButton.BackColor == Color.CornflowerBlue && transferButton.ForeColor == Color.White)
            {
                transferButton.BackColor = Color.AliceBlue;
                transferButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void warehouseButton_MouseEnter(object sender, EventArgs e)
        {
            if (warehouseButton.BackColor == Color.AliceBlue && warehouseButton.ForeColor == SystemColors.MenuHighlight)
            {
                warehouseButton.BackColor = Color.CornflowerBlue;
                warehouseButton.ForeColor = Color.White;
            }
        }

        private void warehouseButton_MouseLeave(object sender, EventArgs e)
        {
            if (warehouseButton.BackColor == Color.CornflowerBlue && warehouseButton.ForeColor == Color.White)
            {
                warehouseButton.BackColor = Color.AliceBlue;
                warehouseButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void administrativeToolsButton_MouseEnter(object sender, EventArgs e)
        {
            if (administrativeToolsButton.BackColor == Color.AliceBlue && administrativeToolsButton.ForeColor == SystemColors.MenuHighlight)
            {
                administrativeToolsButton.BackColor = Color.CornflowerBlue;
                administrativeToolsButton.ForeColor = Color.White;
            }
        }

        private void administrativeToolsButton_MouseLeave(object sender, EventArgs e)
        {
            if (administrativeToolsButton.BackColor == Color.CornflowerBlue && administrativeToolsButton.ForeColor == Color.White)
            {
                administrativeToolsButton.BackColor = Color.AliceBlue;
                administrativeToolsButton.ForeColor = SystemColors.MenuHighlight;
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }
    }
}
