using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace mystore
{
    public partial class Login : Form
    {
        
        public static string username = "";

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Login()
        {
            InitializeComponent();

           
        }

        private void LOGINbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from signup where name = @name and password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name" , USERNAMEtextBox.Text);
            cmd.Parameters.AddWithValue("@password", PASSWORDtextBox.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username = USERNAMEtextBox.Text;
                
                Form1 mainform = new Form1();
                // method 1 
               /* if(mainform.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(mainform);
                }
                else
                {
                    Application.Exit();
                }*/
               // method 2
               this.Hide(); 
                mainform.ShowDialog();
                this.Close();   
                
                  
               
            }
            else
            {
                MessageBox.Show("Login Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void SHOWPASSWORDcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = SHOWPASSWORDcheckBox.Checked;
            switch(check)
            {
                case true:
                    PASSWORDtextBox.UseSystemPasswordChar = false;
                    break;

                default:
                    PASSWORDtextBox.UseSystemPasswordChar = true;
                    break;  

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupform = new Signup();
            this.Hide();
            signupform.ShowDialog();
            this.Close();
        }
    }
}
