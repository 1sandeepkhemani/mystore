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
    public partial class DeleteItem : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public DeleteItem()
        {
            InitializeComponent();
            datablindgridview();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Form1 MainFrom = new Form1();
            this.Hide();
            MainFrom.ShowDialog();
            this.Close();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.items_tbl' table. You can move, or remove it, as needed.
            //this.items_tblTableAdapter.Fill(this.database1DataSet.items_tbl);

        }

        private void ADDCIRCLEBUTTON_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cmd = new SqlCommand("delete from items_tbl where item_id = @item_id", con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@item_id", ItemIdTextBox.Text);
            


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Delete Item SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            datablindgridview();

            reset();
        }

        void reset()
        {
            ItemIdTextBox.Clear();
            ITEMNAMETextBox.Clear();
            PRICETextBox.Clear();
            DISCOUNTTextBox.Clear();
            TAXComboBox.SelectedItem = null;
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ItemIdTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ITEMNAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PRICETextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DISCOUNTTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            TAXComboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
