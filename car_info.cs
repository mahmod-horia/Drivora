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
using System.IO;

namespace drivora
{
    public partial class car_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");
        public car_info()
        {
            InitializeComponent();
            button3.Enabled = false;
            button1.Enabled = false;
            cTextBox6.Visible = false;

            //جلب البيانات من القاعدة وعرضها داخل داتا غريد فيو
            SqlDataAdapter show = new SqlDataAdapter("select * from cars" , con);
            DataTable dt = new DataTable();
            show.Fill(dt);
            dataGridView1.DataSource = dt;
            label1.Text = dt.Rows.Count.ToString();
            
        }

        // برمجة زر اضافة بيانات
        private void button2_Click(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(cTextBox1.Text) && string.IsNullOrEmpty(cTextBox2.Text) && string.IsNullOrEmpty(cTextBox3.Text) && string.IsNullOrEmpty(cTextBox4.Text) && string.IsNullOrEmpty(cTextBox5.Text))
            {
                MessageBox.Show("One of the fields is empty...");
            }
            else
            {
                MemoryStream ba = new MemoryStream();
                pictureBox1.Image.Save(ba, System.Drawing.Imaging.ImageFormat.Jpeg);
                var save = ba.ToArray();
                // كود اضافه بيانات الى القاعدة
                SqlCommand add = new SqlCommand("insert into cars (Car_Type,Car_Model,Car_Number,Car_Color,price,Car_Image) values(@type,@model,@number,@color,@price,@image)", con);
                add.Parameters.AddWithValue("@type", cTextBox1.Text);
                add.Parameters.AddWithValue("@model", cTextBox2.Text);
                add.Parameters.AddWithValue("@number", cTextBox3.Text);
                add.Parameters.AddWithValue("@color", cTextBox4.Text);
                add.Parameters.AddWithValue("@price", cTextBox5.Text);
                add.Parameters.AddWithValue("@image", save);
                con.Open();
                add.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The car has been added successfully...");
                Show();
            }
            
        }

        // كود برمجه زر ادراج صورة
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "select image";
            open.Filter = "ImageFile(*.jpg;*.png)|*.jpg;*.png";
            if(open.ShowDialog() == DialogResult.OK) 
                pictureBox1.Image = Image.FromFile(open.FileName);
        }

        // كود برمجة زر اعادة التحميل
        private void button4_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from cars", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cTextBox1.Clear();
            cTextBox2.Clear();
            cTextBox3.Clear();
            cTextBox4.Clear();
            cTextBox5.Clear();
            pictureBox1.Controls.Clear();
            label1.Text = dt.Rows.Count.ToString();


        }

        // برمجة زر خذف البيانات
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand delet = new SqlCommand("delete from cars where id = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                delet.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The car has been successfully deleted...");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ERROR : Please select a car to delete.");
            }
        }

        // برمجة زر تعديل البيانات
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTextBox1.Text) || string.IsNullOrEmpty(cTextBox2.Text) || string.IsNullOrEmpty(cTextBox3.Text) || string.IsNullOrEmpty(cTextBox4.Text) || string.IsNullOrEmpty(cTextBox5.Text))
            {
                MessageBox.Show("One of the fields is empty...");
            }
            else
            {
                SqlCommand edit = new SqlCommand("Update cars set Car_Type = '" + cTextBox1.Text + "',Car_Model = '" + cTextBox2.Text + "' ,Car_Number = '" + cTextBox3.Text + "' ,Car_Color = '" + cTextBox4.Text + "', price = '" + cTextBox5.Text + "' where id = '" +Convert.ToInt32( cTextBox6.Text) + "'", con);


                con.Open();
                edit.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The car has been successfully modified...");

               
            }
        }

        // كود برمجة عند الضغط ضغطتين على احد البيانات داخل داتا غريد فيو
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cTextBox6.Visible = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                cTextBox6.Text = selectedRow.Cells["id"].Value?.ToString();
                cTextBox1.Text = selectedRow.Cells["Car_Type"].Value?.ToString();
                cTextBox2.Text = selectedRow.Cells["Car_Model"].Value?.ToString();
                cTextBox3.Text = selectedRow.Cells["Car_Number"].Value?.ToString();
                cTextBox4.Text = selectedRow.Cells["Car_Color"].Value?.ToString();
                cTextBox5.Text = selectedRow.Cells["price"].Value?.ToString();
            }
            
        }
    }
}
