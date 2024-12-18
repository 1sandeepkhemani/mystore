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
    public partial class Form1 : Form
    {

        int SrNo = 0;
        int FinalCost = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {

            InitializeComponent();

            GetInvoiceId();

            USERtextBox.Text = Login.username;

            GetItems();


            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "SR NO";
            dataGridView1.Columns[1].Name = "ITEM NAME";
            dataGridView1.Columns[2].Name = "UNIT PRICE";
            dataGridView1.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView1.Columns[4].Name = "QUANTITY";
            dataGridView1.Columns[5].Name = "SUB TOTAL";
            dataGridView1.Columns[6].Name = "TAX";
            dataGridView1.Columns[7].Name = "TOTAL COST";

        }

        void GetItems()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_name = dr.GetString(1);
                ITEMcomboBox.Items.Add(item_name);
            }
            con.Close();
        }

        void GetPrice()
        {
            if (ITEMcomboBox.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;

                SqlConnection con = new SqlConnection(cs);
                string query = "select item_price from items_tbl where item_name = @name";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@name", ITEMcomboBox.SelectedItem.ToString());

                DataTable data = new DataTable();
                da.Fill(data);

                if (data.Rows.Count > 0)
                {

                    price = Convert.ToInt32(data.Rows[0]["item_price"]);
                }

                PRICEtextBox.Text = price.ToString();
            }
        }

        void GetDiscount()
        {
            if (ITEMcomboBox.SelectedItem == null)
            {

            }
            else
            {
                int discount = 0;

                SqlConnection con = new SqlConnection(cs);
                string query = "select item_discount from items_tbl where item_name = @name";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@name", ITEMcomboBox.SelectedItem.ToString());

                DataTable data = new DataTable();
                da.Fill(data);

                if (data.Rows.Count > 0)
                {

                    discount = Convert.ToInt32(data.Rows[0]["item_discount"]);
                }

                DISCOUNTtextBox.Text = discount.ToString();
            }
        }



        private void ITEMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
            GetDiscount();

            QUANTITYtextBox.Enabled = true;
        }

        private void QUANTITYtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QUANTITYtextBox.Text) == true)
            {

            }

            else
            {

                int price = Convert.ToInt32(PRICEtextBox.Text);
                int discount = Convert.ToInt32(DISCOUNTtextBox.Text);
                int quantity = Convert.ToInt32(QUANTITYtextBox.Text);

                int subcost = price * quantity;
                subcost = subcost - discount * quantity;

                SUBTOTALtextBox.Text = subcost.ToString();

            }

        }

        private void TAXtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAXtextBox.Text) == true)
            {

            }
            else
            {
                int subtotal = Convert.ToInt32(SUBTOTALtextBox.Text);
                int tax = Convert.ToInt32(TAXtextBox.Text);

                int totalcost = subtotal + tax;

                TOTALCOSTtextBox.Text = totalcost.ToString();
            }
        }

        private void SUBTOTALtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SUBTOTALtextBox.Text) == true)
            {

            }
            else
            {
                int totaltax = 0;

                SqlConnection con = new SqlConnection(cs);
                string query = "select item_tax from items_tbl where item_name = @name";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@name", ITEMcomboBox.SelectedItem.ToString());

                DataTable data = new DataTable();
                da.Fill(data);

                if (data.Rows.Count > 0)
                {

                    int tax = Convert.ToInt32(data.Rows[0]["item_tax"]);
                    int subtotal = Convert.ToInt32(SUBTOTALtextBox.Text);

                    totaltax = (tax * subtotal) / 100;
                }

                TAXtextBox.Text = totaltax.ToString();
            }
        }




        void AddData(string sr_no, string item_name, string unit_price, string discount, string quantity, string sub_total, string tax, string total_cost)
        {
            string[] row = { sr_no, item_name, unit_price, discount, quantity, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);

        }



        void Reset()
        {
            ITEMcomboBox.SelectedItem = null;
            PRICEtextBox.Clear();
            DISCOUNTtextBox.Clear();
            QUANTITYtextBox.Clear();
            SUBTOTALtextBox.Clear();
            TAXtextBox.Clear();
            TOTALCOSTtextBox.Clear();
            FINALCOSTtextBox.Clear();
            AMOUNTPAIDtextBox.Clear();
            CHANGEtextBox.Clear();
            QUANTITYtextBox.Enabled = false;

        }





        void GetFinalCost()
        {
            FinalCost = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                FinalCost = FinalCost + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            FINALCOSTtextBox.Text = FinalCost.ToString();
        }

        private void AMOUNTPAIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AMOUNTPAIDtextBox.Text) == true)
            { }

            else
            {
                int amountpaid = Convert.ToInt32(AMOUNTPAIDtextBox.Text);
                int fcost = Convert.ToInt32(FINALCOSTtextBox.Text);
                int change = amountpaid - fcost;

                CHANGEtextBox.Text = change.ToString();
            }
        }

        private void CLEARGRIDVIEWbutton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            AddData((++SrNo).ToString(), ITEMcomboBox.SelectedItem.ToString(), PRICEtextBox.Text, DISCOUNTtextBox.Text, QUANTITYtextBox.Text, SUBTOTALtextBox.Text, TAXtextBox.Text, TOTALCOSTtextBox.Text);
            Reset();
            GetFinalCost();

        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.Rows.Clear();
            SrNo = 0;
        }

        void GetInvoiceId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select invoiceid from [order]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            da.Fill(data);
            if (data.Rows.Count < 1)
            {
                INVOICEtextBox.Text = "1";

            }
            else
            {
                string query2 = "select max(invoiceid) from [order]";
                SqlCommand cmd = new SqlCommand(query2, con);
                con.Open();
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                a = a + 1;
                INVOICEtextBox.Text = a.ToString();
                con.Close();
            }
        }

        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();

            cmd = new SqlCommand("insert into [order](invoiceid, username, datetime, finalcost) values(@invoiceid, @username, @datetime, @finalcost)", con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@invoiceid", INVOICEtextBox.Text);
            cmd.Parameters.AddWithValue("@username", USERtextBox.Text);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
            cmd.Parameters.AddWithValue("@finalcost", FINALCOSTtextBox.Text);




            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            

            MessageBox.Show("SuccessFull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            insertintoorderdetail();

            GetInvoiceId();
            Reset();


        }

        int getlastinsertinvoiceid()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd;

            cmd = new SqlCommand("select max(invoiceid) from [order] ",con);
            int maxinvoiceid = Convert.ToInt32(cmd.ExecuteScalar());    
            con.Close();
            return maxinvoiceid;
        }

        void insertintoorderdetail()
        {
            int a = 0;
            SqlConnection con = new SqlConnection(cs);

            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("insert into [orderdetail](invoiceid, itemname, itemprice, discountperitem, quantity, subtotal, tax, totalcost) values(@invoiceid, @itemname, @itemprice, @discountperitem, @quantity, @subtotal, @tax, @totalcost)", con);

                    cmd.Parameters.AddWithValue("@invoiceid", getlastinsertinvoiceid());
                    cmd.Parameters.AddWithValue("@itemname", dataGridView1.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@itemprice", dataGridView1.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@discountperitem", dataGridView1.Rows[i].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value.ToString());
                    cmd.Parameters.AddWithValue("@totalcost", dataGridView1.Rows[i].Cells[7].Value.ToString());

                    a = a + cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            catch
            {
              
            }

            if(a>0)
            {
                MessageBox.Show("SuccessFull  Data Added in Order Detail Table!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Failed !!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PREVIEWbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                
            }


        }

        private void PRINTbutton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            Bitmap bmp = Properties.Resources.Mystore;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 5, 800, 250);
            e.Graphics.DrawString("Invoice Id : " + INVOICEtextBox.Text, new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("User Name : " + USERtextBox.Text, new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time : " + DateTime.Now.ToShortTimeString(), new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(00, 420));
            e.Graphics.DrawString("ITEM", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("PRICE", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(180, 450));
            e.Graphics.DrawString("QUANTITY", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(270, 450));
            e.Graphics.DrawString("DISCOUNT", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(390, 450));
            e.Graphics.DrawString("SUB TOTAL", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(510, 450));
            e.Graphics.DrawString("TAX", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(650, 450));
            e.Graphics.DrawString("TOTAL", new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(750, 450));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(00, 470));

            int gap;

            //Item name
            gap = 500;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Bell Mt", 11, FontStyle.Bold), Brushes.Black, new Point(30, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            //Price
            gap = 500;
            if(dataGridView1.Rows.Count > 0 )
            {
                for(int i = 0;i < dataGridView1.Rows.Count;i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(185, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            //Quantity
            gap=500;
            if( dataGridView1.Rows.Count > 0 )
            {
                for(int i = 0; i< dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(295, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            //Discount
            gap = 500;
            if( dataGridView1.Rows.Count > 0 )
            {
                for (int i = 0; i< dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(415, gap));
                        gap = gap + 30;
                    }
                    catch
                    {


                    }
                }
            }

            //Sub Total
            gap = 500;
            if (dataGridView1.Rows.Count > 0 )
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(535, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            //Tax
            gap = 500;
            if (dataGridView1.Rows.Count > 0 )
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(655, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }

            //Total Cost
            gap = 500;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(760, gap));
                        gap = gap + 30;
                    }
                    catch
                    {

                    }
                }
            }


            //Total Sub Total Price
            int SubTotalPrice= 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SubTotalPrice = SubTotalPrice + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }

            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(00, 870));
            e.Graphics.DrawString("Sub Total Before Tax : "+SubTotalPrice.ToString(), new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 900));

            // Total Tax
            int TotalTax = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                TotalTax = TotalTax + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            e.Graphics.DrawString("Total Tax : " + TotalTax.ToString(), new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 930));
            e.Graphics.DrawString("Final Cost After Tax : " + FINALCOSTtextBox.Text, new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 960));
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(00, 990));
            e.Graphics.DrawString("Amount Paid : " + AMOUNTPAIDtextBox.Text, new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1020));
            e.Graphics.DrawString("Change : " + CHANGEtextBox.Text, new Font("Bell Mt", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1050));

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            // method 1 
            /* if(logout.ShowDialog() == DialogResult.OK)
             {
                 Application.Run(logout);
             }
             else
             {
                 Application.Exit();
             }*/
            // method 2
            this.Hide();
            logout.ShowDialog();
            this.Close();
        }

        
           

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem adds = new AddItem();
            // method 1 
            /* if(adds.ShowDialog() == DialogResult.OK)
             {
                 Application.Run(logout);
             }
             else
             {
                 Application.Exit();
             }*/
            // method 2
            this.Hide();
            adds.ShowDialog();
            this.Close();
        
    }

        private void uPDATEITEMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UpdateItem update = new UpdateItem();
            this.Hide();
            update.ShowDialog();
            this.Close();
        }

        private void dELETEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem delete = new DeleteItem();
            this.Hide();
            delete.ShowDialog();
            this.Close();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewData view = new ViewData();
            this.Hide();
            view.ShowDialog();
            this.Close();
        }

        private void detailSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            this.Hide();
            detail.ShowDialog();
            this.Close();
        }
    }

}

              

