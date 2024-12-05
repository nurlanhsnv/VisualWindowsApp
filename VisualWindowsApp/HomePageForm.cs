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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
            UcSale uc = new UcSale();
            addUserControl(uc);
        }
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            label16.Text=DataClass.Users.First().Name;
            label17.Text=DataClass.Users.First().Role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void State()
        {
            guna2Button1.Checked = false;
            guna2Button2.Checked = false;
            guna2Button3.Checked = false;
            guna2Button4.Checked = false;
            guna2Button5.Checked = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            State();
             guna2Button1.Checked = true;
            UcSale uc = new UcSale();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            State();
            guna2Button2.Checked = true;
            UcPurchase uc = new UcPurchase();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            State();
            guna2Button3.Checked = true;
            UcPayment uc = new UcPayment();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            State();
            guna2Button4.Checked = true;
            UcReturns uc = new UcReturns();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            State();
            guna2Button5.Checked = true;
            UcExpense uc = new UcExpense();
            addUserControl(uc);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        
        bool sideBar = true;  
        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            sideTimer.Start();  
        }

        private void sideTimer_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                Point currentLocation = sideP.Location;
                currentLocation.X =30;  
               

                flowLayoutPanel1.Width -= 50;  
                if (flowLayoutPanel1.Width <= 11)  
                {
                    sideP.Location = currentLocation;
                    sideTimer.Stop();
                    sideBar = false;  
                }
            }
            else
            {
                Point currentLocation = sideP.Location;
                currentLocation.X = 303;  
               

                flowLayoutPanel1.Width += 50;  
                if (flowLayoutPanel1.Width > 270) 
                {
                    sideP.Location = currentLocation;
                    sideTimer.Stop();
                    sideBar = true;  
                }
            }
        }

        private void dashboardButton_MouseEnter(object sender, EventArgs e)
        {
            if(dashboardButton.BackColor == Color.AliceBlue && dashboardButton.ForeColor==SystemColors.MenuHighlight)
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

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Hide();
        }
    }
}
