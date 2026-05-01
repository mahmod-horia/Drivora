using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace drivora
{
    public partial class frmmain : Form
    {
        int move;
        int movx;
        int movy;
        public frmmain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car_info show_car = new car_info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            showfrm(show_car);

        }
        void showfrm (Control frm)
        {
            this.panelmain.Controls.Clear();
            this.panelmain.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            messegebox show = new messegebox();
            show.Show();
            this.Hide();
            
        }
        //-----------------------------------------------//
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }
        //-----------------------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timefrm show = new timefrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showfrm2 (show);
        }
        void showfrm2(Control frm2)
        {
            this.panelmain.Controls.Clear();
            this.panelmain.Controls.Add(frm2);
            frm2.Show();
        }
        //-----------------------------------------------//

        // اكواد ازرار التواصل الاجتماعي
        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/mahmod.sy.99590");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/mahmodsy710?igsh=MzVsZ2Jtb3Rzd2Q0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://wa.me/message/3TK72C2OWSQ5O1");
        }

        //----------------------------------------------//

        private void button3_Click(object sender, EventArgs e)
        {
            user_info show_car = new user_info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showfrm3(show_car);
        }
        void showfrm3(Control frm3)
        {
            this.panelmain.Controls.Clear();
            this.panelmain.Controls.Add(frm3);
            frm3.Show();
        }
    }
}