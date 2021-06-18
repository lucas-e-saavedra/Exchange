using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;

namespace WinFormsApp1
{
    public partial class FormComprobantes : Form
    {
        public FormComprobantes()
        {
            InitializeComponent();
        }

        private void rb_Depositos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Depositos.Checked)
                gv_Operaciones.DataSource = OperacionesBLL.Current.ConsultarDepositos();
        }

        private void rb_Extracciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Extracciones.Checked)
                gv_Operaciones.DataSource = OperacionesBLL.Current.ConsultarExtracciones();
        }

        private void rb_Transferencias_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Transferencias.Checked)
                gv_Operaciones.DataSource = OperacionesBLL.Current.ConsultarTransferencias();
        }
    }
}
