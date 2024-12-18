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

namespace mystore
{
    public partial class Detail : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Detail()
        {
            InitializeComponent();
            datablindgridview();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        void datablindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "orderbothtable";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "orderbothtableinvoicesearch";
            SqlCommand cmd = new SqlCommand(query, con);
          
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invoice", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView1.DataSource = data;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[0].Visible = false; 
            dataGridView1.Columns[1].Visible = false;

           textBox2.Text= dataGridView1.Rows[0].Cells[0].Value.ToString();
           textBox3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
           textBox4.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "orderbothtabledate";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@from", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@to", dateTimePicker2.Value);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datablindgridview();
            dataGridView1.Columns[10].Visible = true;
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
