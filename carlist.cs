using System;
using System.Collections;
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
    public partial class carlist : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");

        public carlist()
        {
            InitializeComponent();

            // كود جلب البيانات وعرضها داخل داتا غريد فيو

            SqlDataAdapter show = new SqlDataAdapter("select * from cars", con);
            DataTable dt = new DataTable();
            show.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();
        }

        // كود عند الضغط على احد البيانات يتم تعبئة الحقول بنفس البيانات التي تم الضفط عليها
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cTextBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            cTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            cTextBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            cTextBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            cTextBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            cTextBox9.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        // كود بركجة زر اضافه طلب استأجار
        private void button1_Click(object sender, EventArgs e)
        {
           
           

                if (string.IsNullOrEmpty(cTextBox6.Text) || string.IsNullOrEmpty(cTextBox7.Text) || string.IsNullOrEmpty(cTextBox8.Text))
                {
                    MessageBox.Show("username or password is Empty...");
                }
                else
                {
                    SqlCommand add = new SqlCommand(" insert into rental values('" + cTextBox6.Text + "','" + cTextBox7.Text + "','" + cTextBox8.Text + "','" + cTextBox1.Text + "','" + cTextBox2.Text + "','" + cTextBox3.Text + "','" + cTextBox4.Text + "','" + cTextBox9.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "')", con);
                    con.Open();
                    add.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The account has been created successfully...");
                    cTextBox6.Clear();
                    cTextBox7.Clear();
                    cTextBox8.Clear();
                    cTextBox1.Clear();
                    cTextBox2.Clear();
                    cTextBox3.Clear();
                    cTextBox4.Clear();
                    cTextBox5.Clear();
                    cTextBox9.Clear();

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from cars", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
