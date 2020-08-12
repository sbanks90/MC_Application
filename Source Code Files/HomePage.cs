using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Application
{
    public partial class FormHomePage : Form
    {
        
        
        public FormHomePage()
        {
            InitializeComponent();
                        
        }



        private void FormHomePage_Load_1(object sender, EventArgs e)
        {
            textBoxWelcome.Text = "Welcome " + FormLogIn.welcomeText + "!";
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
         }

        //  ALL 6 ACTION BUTTONS ON HOME PAGE 
        //  brings the User Control to the front and 
        //  moves the sidebar to the respective button as an indicator

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucCustomers.Instance);
            ucCustomers.Instance.BringToFront();
            panelSidePanel.Height = pictureBox1.Height;
            panelSidePanel.Top = pictureBox1.Top;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucOrders.Instance);
            ucOrders.Instance.BringToFront();
            panelSidePanel.Height = pictureBox2.Height;
            panelSidePanel.Top = pictureBox2.Top;
        }

        private void buttonPackingSlips_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucPackingSlips.Instance);
            ucPackingSlips.Instance.BringToFront();
            panelSidePanel.Height = pictureBox3.Height;
            panelSidePanel.Top = pictureBox3.Top;
        }

        private void buttonInvoices_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucInvoices.Instance);
            ucInvoices.Instance.BringToFront();
            panelSidePanel.Height = pictureBox4.Height;
            panelSidePanel.Top = pictureBox4.Top;
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucItems.Instance);
            ucItems.Instance.BringToFront();
            panelSidePanel.Height = pictureBox5.Height;
            panelSidePanel.Top = pictureBox5.Top;
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ucUsers.Instance);
            ucUsers.Instance.BringToFront();
            panelSidePanel.Height = pictureBox6.Height;
            panelSidePanel.Top = pictureBox6.Top;
        }


        private void buttonAddPackingSlip_Click(object sender, EventArgs e)
        {
            NewPackingSlip newPS = new NewPackingSlip();
            newPS.Show();
            panelSidePanel.Height = pictureBox3.Height;
            panelSidePanel.Top = pictureBox3.Top;
            //this.Hide();

        }


        //
        //  THIS IS TO MOVE THE WINDOW BUT CAN BE GLITCHY
        //

        int mov, movX, movY;
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }






















        // stuff I clicked on accidentally but don't want to delete in case it messes up the app...
        private void ucPackingSlips_Load(object sender, EventArgs e)
        {

        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}
