using Domain;
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
    public partial class FormDestinoTransferencia : Form
    {
        private FormDestinoTransferencia()
        {
            InitializeComponent();
        }

        
        private Cuenta cuentaOrigen;
        private float montoOrigen;
        public FormDestinoTransferencia(Cuenta origen, float monto) {
            this.cuentaOrigen = origen;
            this.montoOrigen = monto;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CajaAhorro.Checked)
                gv_CuentasDestino.DataSource = CajaAhorroBLL.Current.GetAll();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Wallet.Checked)
                gv_CuentasDestino.DataSource = WalletBLL.Current.GetAll();
        }


        Cuenta selectedDestino = null;
        private void gv_CuentasDestino_SelectionChanged(object sender, EventArgs e)
        {
            if (rb_CajaAhorro.Checked && gv_CuentasDestino.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv_CuentasDestino.SelectedRows[0];
                CajaAhorro unaCajaAhorro = new CajaAhorro();
                unaCajaAhorro.guid = Guid.Parse(row.Cells[2].Value.ToString());
                unaCajaAhorro.cbu = row.Cells[0].Value.ToString();
                unaCajaAhorro.cuit = row.Cells[1].Value.ToString();
                unaCajaAhorro.saldo = float.Parse(row.Cells[3].Value.ToString());
                selectedDestino = unaCajaAhorro;
            }
            if (rb_Wallet.Checked && gv_CuentasDestino.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gv_CuentasDestino.SelectedRows[0];
                Wallet oneWallet = new Wallet();
                oneWallet.guid = Guid.Parse(row.Cells[1].Value.ToString());
                oneWallet.direccion = row.Cells[0].Value.ToString();
                oneWallet.saldo = float.Parse(row.Cells[2].Value.ToString());
                selectedDestino = oneWallet;
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesBLL.Current.Transferir(cuentaOrigen, selectedDestino, montoOrigen);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
