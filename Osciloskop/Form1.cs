using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Osciloskop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void zoomBar_ValueChanged(object sender, EventArgs e)
        {
            osci.zoom = zoomBar.Value*10;
        }

        private void connButton_Click(object sender, EventArgs e)
        {
            osci.OpenEsp();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            osci.StartOsciOnEsp();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            osci.DisconnectEsp();
        }

        private void RestartEspButton_Click(object sender, EventArgs e)
        {
            osci.RebootEsp();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                osci.ChangeFrequencyEsp(Convert.ToInt32(RefreshRateTextBox.Text));
            }
            catch { }
        }
    }
}
