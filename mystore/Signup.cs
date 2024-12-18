using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mystore
{
    public partial class Signup : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
       

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cmd = new SqlCommand("insert into [signup](name,gender,age,email,password,confirmpass) values(@name, @gender, @age, @email, @password, @confirmpass)", con);
            
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
            cmd.Parameters.AddWithValue("@gender", GenderComboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@age", AgeNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
            cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
            cmd.Parameters.AddWithValue("@confirmpass", ConfirmTextBox.Text);

            cmd.ExecuteNonQuery();
           cmd.Dispose();
            con.Close();

            MessageBox.Show("Sigup SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Username is :"+ NameTextBox.Text + "\n\n"+ "Password is :"+ PasswordTextBox.Text ,"Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login LoginForm = new Login();
            this.Hide();
            LoginForm.ShowDialog();
            this.Close();
            Reset();

        }

        void Reset()
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmTextBox.Clear();
            GenderComboBox.SelectedItem= null;
            AgeNumericUpDown.Value = 0;
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.ShowDialog();
            this.Close();
        }
    }
}
