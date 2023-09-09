using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI.webcontols;


namespace PREPARE
{
    public partial class mYForm2 : Form
    {
       
        public mYForm2()
        {
            InitializeComponent();
        }
        public SqlCommand comm;
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-ndo\SQLEXPRESS;Initial Catalog=toothsomemeals;Integrated Security=True");

        public int res;


        private void GO_Click(object sender, EventArgs e)
        {
            //res = int.Parse(textB.Text);
            Form1 fom1 = new Form1();
            fom1.ShowDialog();
            this.Hide();

        }
        public int calc(int val)
        {
            return val * 50;
        }

        private void mYForm2_Load(object sender, EventArgs e)
        {
         
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-ndo\SQLEXPRESS;Initial Catalog=toothsomemeals;Integrated Security=True"; // Replace with your SSMS connection string
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {

                    string qry = "SELECT * FROM [Order]"; // Replace [YourTableName] with the actual table name

                    cnn.Open();

                    // Create a SqlDataAdapter and DataSet
                    SqlDataAdapter adp = new SqlDataAdapter(qry, cnn);
                    DataSet dt = new DataSet();

                    // Fill the DataSet with data from the SQL query
                    adp.Fill(dt);

                    // Bind the DataSet to the DataGridView
                    dataGridV1.DataSource = dt.Tables[0]; // Assuming the first table in the DataSet contains your data
                    cnn.Close();
                }
            }catch (SqlException ex)
    {
        // Handle SQL Server exception and access error details
        foreach (SqlError error in ex.Errors)
        {
            MessageBox.Show($"SQL Error {error.Number}: {error.Message}");
        }
    }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       /* private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "SELECT *  from Order ";
                cnn.Open();
               // DataSet  ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(qry, cnn);
                adp.SelectCommand = comm;
                DataSet dt = new DataSet();
                adp.Fill(dt);


                dataGridV1.DataSource = dt;
                //dataGridV1.DataBindings();






            }catch
            { MessageBox.Show("error");

            }
            finally { cnn.Close(); }
        }*/
    }
}
