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
    public partial class UpdateItem : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public UpdateItem()
        {
            InitializeComponent();
            datablindgridview();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Form1 MainFrom = new Form1();
            this.Hide();
            MainFrom.ShowDialog();
            this.Close();
        }

        private void ADDCIRCLEBUTTON_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cmd = new SqlCommand("update items_tbl set item_name = @item_name, item_price = @item_price, item_discount = @item_discount, item_tax = @item_tax where item_id = @item_id", con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@item_id", ItemIdTextBox.Text);
            cmd.Parameters.AddWithValue("@item_name", ITEMNAMETextBox.Text);
            cmd.Parameters.AddWithValue("@item_tax", TAXComboBox.SelectedItem.ToString());

            cmd.Parameters.AddWithValue("@item_price", PRICETextBox.Text);
            cmd.Parameters.AddWithValue("@item_discount", DISCOUNTTextBox.Text);


            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Update Item SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemIdTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ITEMNAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PRICETextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DISCOUNTTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            TAXComboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
