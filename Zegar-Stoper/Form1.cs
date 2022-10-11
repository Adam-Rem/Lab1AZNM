using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar_Stoper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zegar.Text = DateTime.Now.ToString("T");

        }

        private void stoper_Click(object sender, EventArgs e)
        {
            Stoper frm1 = new Stoper();
            frm1.Show();
        }
    }
}
