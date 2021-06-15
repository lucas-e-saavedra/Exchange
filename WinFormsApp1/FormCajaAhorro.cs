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
            gv_CajaAhorro.DataSource = CajaAhorroBLL.Current.GetAll();
        }


        CajaAhorro selectedCA = null;
        private void gv_CajaAhorro_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_CajaAhorro.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv_CajaAhorro.SelectedRows[0];
                CajaAhorro unaCajaAhorro = new CajaAhorro();
                unaCajaAhorro.guid = Guid.Parse(row.Cells[2].Value.ToString());
                unaCajaAhorro.cbu = row.Cells[0].Value.ToString();
                unaCajaAhorro.cuit = row.Cells[1].Value.ToString();
                unaCajaAhorro.saldo = float.Parse(row.Cells[3].Value.ToString());
                selectedCA = unaCajaAhorro;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesBLL.Current.Depositar(selectedCA, float.Parse(nu_Depositar.Value.ToString()));
                nu_Depositar.Value = 0;
                gv_CajaAhorro.DataSource = CajaAhorroBLL.Current.GetAll();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesBLL.Current.Extraer(selectedCA, float.Parse(nu_Extraer.Value.ToString()));
                nu_Extraer.Value = 0;
                gv_CajaAhorro.DataSource = CajaAhorroBLL.Current.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            { 
                FormDestinoTransferencia form = new FormDestinoTransferencia(selectedCA, float.Parse(nu_Transferir.Value.ToString()));
                form.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
