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
using Domain;

namespace WinFormsApp1
{
    public partial class FormCajaAhorro : Form
    {
        public FormCajaAhorro()
        {
            InitializeComponent();
        }

        private void FormCajaAhorro_Load(object sender, EventArgs e)
        {
            gv_CajaAhorro.DataSource = CajaAhorroBLL.Current.GetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CajaAhorro nuevaCA = new CajaAhorro();
            nuevaCA.guid = Guid.NewGuid();
            nuevaCA.cbu = input_cbu.Text;
            nuevaCA.cuit = input_cuit.Text;
            nuevaCA.saldo = 0;
            CajaAhorroBLL.Current.Add(nuevaCA);
            input_cbu.Clear();
            input_cuit.Clear();
        }
    }
}
