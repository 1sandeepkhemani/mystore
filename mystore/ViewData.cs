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
    public partial class ViewData : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ViewData()
        {
            InitializeComponent();
            datablindgridview();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        void datablindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView1.DataSource = data;
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            AddItem adds = new AddItem();
            this.Hide();
            adds.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateItem update = new UpdateItem();
            this.Hide();
            update.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteItem delete = new DeleteItem();
            this.Hide();
            delete.ShowDialog();
            this.Close();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            this.Hide();
            mainform.ShowDialog();
            this.Close();
        }
    }
}
