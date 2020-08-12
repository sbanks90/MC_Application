using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MC_Application
{
    
    public partial class FormLogIn : Form
    {

        public static string welcomeText;
        public FormLogIn()
        {
            InitializeComponent();
            
        }


        // Need to tie in database of user info here to utilize real usernames and passwords for logins
        // maybe use boolean code mentioned in notes for it as well
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
                                  
            // basic hard coded username and password set up
            if (textBoxUsername.Text == "Shaun" && textBoxPassword.Text == "password")
            {
                welcomeText = textBoxUsername.Text;
                FormHomePage home = new FormHomePage();
                home.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }


            //SqlConnection con = new SqlConnection(@"Server= 162.241.216.143; Database = montech1_monteChiaroDB; User Id = montech1_user495; Password = Montemonte20!");
            //SqlConnection con = new SqlConnection("server = 162.241.216.143; user id = montech1_user495; persistsecurityinfo = True; database = montech1_monteChiaroDB; allowuservariables = True");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Employee where Employeename= ' " + textBoxUsername.Text + " ' and Password = ' " + textBoxPassword.Text + " ' ", con);
            //DataTable dt = new DataTable();


            //DataAccess db = new DataAccess();

            //db.GetEmployees(textBoxUsername.Text);

            /*
            //sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                welcomeText = textBoxUsername.Text;
                FormHomePage home = new FormHomePage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }*/

        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();

            //MessageBox.Show("Please contact your system administrator for help in resetting your password.");
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
