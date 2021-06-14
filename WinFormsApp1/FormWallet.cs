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
    public partial class FormWallet : Form
    {
        public FormWallet()
        {
            InitializeComponent();
        }

        private void FormWallet_Load(object sender, EventArgs e)
        {
            gv_wallet.DataSource = WalletBLL.Current.GetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Wallet nuevaWallet = new Wallet();
            nuevaWallet.guid = Guid.NewGuid();
            nuevaWallet.direccion = input_direccion.Text;
            nuevaWallet.saldo = 0;
            WalletBLL.Current.Add(nuevaWallet);
            input_direccion.Clear();
            gv_wallet.DataSource = WalletBLL.Current.GetAll();
        }

        private void input_direccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            byte[] buffer = new byte[50 / 2];
            random.NextBytes(buffer);
            string hexString = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            
            input_direccion.Text = hexString;
        }

        Wallet selectedWallet = null;
        private void gv_wallet_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_wallet.SelectedRows.Count > 0)
            {        
                DataGridViewRow row = gv_wallet.SelectedRows[0];
                Wallet oneWallet = new Wallet();
                String bla = row.Cells[0].Value.ToString();
                oneWallet.guid = Guid.Parse(row.Cells[1].Value.ToString());
                oneWallet.direccion = row.Cells[0].Value.ToString();
                oneWallet.saldo = float.Parse(row.Cells[2].Value.ToString());

                selectedWallet = oneWallet;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesBLL.Current.Depositar(selectedWallet, float.Parse(input_Depositar.Text.ToString()));
                input_Depositar.Clear();
                gv_wallet.DataSource = WalletBLL.Current.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                OperacionesBLL.Current.Extraer(selectedWallet, float.Parse(input_Extraer.Text.ToString()));
                input_Extraer.Clear();
                gv_wallet.DataSource = WalletBLL.Current.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
