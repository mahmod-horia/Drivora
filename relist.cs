using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drivora
{
    public partial class relist : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");

        public relist()
        {
            InitializeComponent();

            SqlDataAdapter show = new SqlDataAdapter("select * from rental", con);
            DataTable dt = new DataTable();
            show.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from rental", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand delet = new SqlCommand("delete from rental where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                delet.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The request has been successfully deleted...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : Please select a request to delete.");
            }
        }
    }
}
