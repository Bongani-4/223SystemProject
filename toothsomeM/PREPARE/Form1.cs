using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PREPARE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mYForm2 fom1 = new mYForm2();
            fom1.ShowDialog();

            int ires = fom1.calc(fom1.res);
            // labelr.Text = ires.ToString();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    SqlConnection cnn =  new SqlConnection(@"Data Source=LAPTOP-ndo\SQLEXPRESS;Initial Catalog=toothsomemeals;Integrated Security=True");
        }
    }
}
