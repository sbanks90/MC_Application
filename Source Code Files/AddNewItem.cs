using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Application
{
    public partial class AddNewItem : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shaun\MC_Crunch.mdf;Integrated Security=True;Connect Timeout=30";
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connString);

            try
            {
                string saveItem = "INSERT INTO TableItems (ItemID, Item, PackSize, Client) VALUES(@ItemID, @Item, @PackSize, @Client)";
                
                SqlCommand sqlCmd = new SqlCommand(saveItem);


                sqlCmd.Connection = sqlCon;
                sqlCmd.Parameters.AddWithValue("@ItemID", textBoxItemID.Text);
                sqlCmd.Parameters.AddWithValue("@Item", textBoxDescription.Text);
                sqlCmd.Parameters.AddWithValue("@PackSize", textBoxPackSize.Text);
                sqlCmd.Parameters.AddWithValue("@Client", cbxClient.Text);
                sqlCon.Open();
                

                int affected = sqlCmd.ExecuteNonQuery();
                if (affected > 0)
                    MessageBox.Show("New item information saved!");
                else
                    MessageBox.Show("No information inserted.");
                sqlCon.Close();



            }
           catch (Exception ex)
           {
              MessageBox.Show("ERROR:" + ex.Message);
           }
            this.Close();
        }
    }
}
