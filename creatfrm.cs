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
    public partial class creatfrm : Form
    {
        int move;
        int movx;
        int movy;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahmoud SY\Documents\datauser.mdf;Integrated Security=True;Connect Timeout=30");
        
        public creatfrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 get = new Form1();
            get.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxuser.Text) || string.IsNullOrEmpty(textBoxgmail.Text) || string.IsNullOrEmpty(textBoxpass.Text) || string.IsNullOrEmpty(textBoxphone.Text))
                {
                    MessageBox.Show("username or password is Empty...");
                }
                else
                {
                    SqlCommand add = new SqlCommand("insert into users values('" + textBoxuser.Text + "','" + textBoxgmail.Text + "','" + textBoxphone.Text + "','" + textBoxpass.Text + "')", con);
                    con.Open();
                    add.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The account has been created successfully...");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            };
            
            
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
