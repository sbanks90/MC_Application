using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;

namespace MC_Application
{
    public partial class AddNewCustomer : Form
    {


        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shaun\MC_Crunch.mdf;Integrated Security=True;Connect Timeout=30";

        public AddNewCustomer()
        {
            InitializeComponent();

        }


        public void buttonSubmitNewCustomer_Click(object sender, EventArgs e)
        {



            SqlConnection sqlCon = new SqlConnection(connString);


                //sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["MC_Application.Properties.Settings.MC_Application_DatabaseConnectionString"].ConnectionString;

            try
                {


                    string saveCX = "INSERT INTO TableClient (ClientID, ClientCode, ClientName, BillingAddress, ShippingAddress, ContactName, ContactEmail, PhoneNumber) VALUES (@ClientID, @ClientCode, @ClientName, @BillingAddress, @ShippingAddress, @ContactName, @ContactEmail, @PhoneNumber)"; 
                    //"(' " + textBoxNewMCnum.Text + " ', ' " + textBoxNewCustomerName.Text + " ', ' " + textBoxNewBillingAddress.Text + " ', ' " + textBoxNewDeliveryAddress.Text + " ',' " + textBoxNewContactName.Text + " ',' " + textBoxNewEmail.Text + " ',' " + textBoxNewContactNumber.Text + " ' )";
                    SqlCommand sqlCmd = new SqlCommand(saveCX);



                    //sqlCmd = new SqlCommand(helpMe, sqlCon);
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.Parameters.AddWithValue("@ClientID", textBoxClientID.Text);
                    sqlCmd.Parameters.AddWithValue("@ClientCode", textBoxNewMCnum.Text);
                    sqlCmd.Parameters.AddWithValue("@ClientName", textBoxNewCustomerName.Text);
                    sqlCmd.Parameters.AddWithValue("@BillingAddress", textBoxNewBillingAddress.Text);
                    sqlCmd.Parameters.AddWithValue("@ShippingAddress", textBoxNewDeliveryAddress.Text);
                    sqlCmd.Parameters.AddWithValue("@ContactName", textBoxNewContactName.Text);
                    sqlCmd.Parameters.AddWithValue("@ContactEmail", textBoxNewEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@PhoneNumber", textBoxNewContactNumber.Text);
                    sqlCon.Open();
                    int affected = sqlCmd.ExecuteNonQuery();
                if (affected > 0)
                        MessageBox.Show("New Customer information saved!");
                else
                    MessageBox.Show("No information inserted.");
                    sqlCon.Close();
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }


            this.Hide();

        }
                private void AddNewCustomer_Load(object sender, EventArgs e)
                {

                }
            
        
    }
}

