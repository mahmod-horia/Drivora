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
    public partial class timefrm : Form
    {
        public timefrm()
        {
            InitializeComponent();
        }

        private void timefrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // كود اظهار التوقيت الحالي
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToString("dd MM yyyy");
        }
    }
}
