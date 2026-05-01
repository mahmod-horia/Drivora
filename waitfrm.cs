using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drivora
{
    public partial class waitfrm : Form
    {
        public waitfrm()
        {
            InitializeComponent();
        }

        //------------------------واجهة جمالية فقط-----------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            frmmain frmmain = new frmmain();
            frmmain.Show();
        }
    }
}
