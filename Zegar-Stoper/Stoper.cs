using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar_Stoper
{
    public partial class Stoper : Form
    {
        private Stopwatch stopwatch;
        public Stoper()
        {
            InitializeComponent();
        }

        private void timers_Tick(object sender, EventArgs e)
        {
            stoper1.Text= string.Format("{0:hh\\:mm\\:ss\\.ff}",stopwatch.Elapsed); 
        }

        private void startb_Click(object sender, EventArgs e)
        {
            timers.Start();
            stopwatch.Start();
        }

        private void Stoper_Load(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();
        }

        private void stopb_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void resetb_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}
