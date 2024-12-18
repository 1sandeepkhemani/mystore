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
    public partial class AddItem : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADDCIRCLEBUTTON_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cmd = new SqlCommand("insert into [items_tbl](item_name,item_price,item_discount,item_tax) values(@item_name, @item_price, @item_discount, @item_tax)", con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@item_name",ITEMNAMETextBox.Text );
            cmd.Parameters.AddWithValue("@item_tax", TAXComboBox.SelectedItem.ToString() );
            cmd.Parameters.AddWithValue("@item_price", PRICETextBox.Text);
            cmd.Parameters.AddWithValue("@item_discount", DISCOUNTTextBox.Text);
           

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            MessageBox.Show("Add Item SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


           
            reset();

        }

        void reset()
        {
            ITEMNAMETextBox.Clear();
            PRICETextBox.Clear();
            DISCOUNTTextBox.Clear();
            TAXComboBox.SelectedItem = null;
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            this.Hide();
            MainForm.ShowDialog();
            this.Close();
        }
    }
}
