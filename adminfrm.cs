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

    public partial class adminfrm : Form
    {
        int move;
        int movx;
        int movy;
        // كود الاتصال بقاعدة البيانات 
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");      
        public adminfrm()
        {
            InitializeComponent();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 get = new Form1();
            get.Show();
            this.Hide();
        }

        // كود برمجة زر إظهار كلمة المرور
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // في حال المستخدم ترك احد الحقول فارغة
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("username or password is Empty...");
            }
            else
            {

                //جلب البيانات من قاعدة البيانات مع شرط أن تكون متطابقه مع البيانات المدخلة
                string query = "SELECT * FROM admin1 WHERE username = @username AND password = @password ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    waitfrm get = new waitfrm();
                    get.Show();
                    this.Hide();
                   

                }
                //في حال كانت البيانات المدخلة غير متطايقه مع الموجوده بالقاعده
                else
                {
                    MessageBox.Show("username or password is wrong...");
                }
            }
            
        }
       

        // اكواد برمجة تحريك واجهة التطبيق
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
    }
}
