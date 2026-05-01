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
    public partial class user_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");

        public user_info()
        {
            InitializeComponent();
            SqlDataAdapter show = new SqlDataAdapter("select * from users", con);
            DataTable dt = new DataTable();
            show.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from users", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand delet = new SqlCommand("delete from users where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                delet.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The user has been successfully deleted...");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR : Please select a user to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            relist relist = new relist();
            relist.Show();
        }
    }
}
