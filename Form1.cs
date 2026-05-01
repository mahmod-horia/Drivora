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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace drivora
{
    public partial class Form1 : Form
    {
        int move;
        int movx;
        int movy;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");

       
        public Form1()
        {
            InitializeComponent();
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creatfrm get = new creatfrm();
            get.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminfrm get_admin = new adminfrm();
            get_admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxuser.Text) && string.IsNullOrEmpty(textBoxpass.Text))
            {
                MessageBox.Show("username or password is Empty...");
            }
            else
            {
                string query = "SELECT * FROM [users] WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBoxuser.Text);
                cmd.Parameters.AddWithValue("@password", textBoxpass.Text);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmwait2 get2 = new frmwait2();
                    get2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password is wrong...");
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxpass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

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
