using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void cajaAhorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCajaAhorro form = new FormCajaAhorro();
            form.MdiParent = this;
            form.Show();
        }

        private void walletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWallet form = new FormWallet();
            form.MdiParent = this;
            form.Show();
        }
    }
}
