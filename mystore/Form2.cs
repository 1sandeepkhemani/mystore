using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mystore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gunaWinCircleProgressIndicator1_Load(object sender, EventArgs e)
        {
           
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar1.Value = startpoint;
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login LoginForm = new Login();
                this.Hide();
                LoginForm.ShowDialog();
                this.Close();
            }
        }

     

        private void Form2_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
