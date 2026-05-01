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
    public partial class frmwait2 : Form
    {
        public frmwait2()
        {
            InitializeComponent();
        }
        //------------------------واجهة جمالية فقط-----------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            frmuser frmmain = new frmuser();
            frmmain.Show();
        }
    }
}
