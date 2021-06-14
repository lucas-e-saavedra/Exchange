using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.Services
{
    public sealed class OperacionesBLL
    {
        private readonly static OperacionesBLL _instance = new OperacionesBLL();

        public static OperacionesBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private OperacionesBLL()
        {
            //Implent here the initialization of your singleton
        }

        public void Depositar(Cuenta unaCuenta, float monto) {
            if (unaCuenta == null)
                throw new Exception("Debe Seleccionar una cuenta");
            if (monto < 0)
                throw new Exception("El monto no es valido");

            unaCuenta.saldo = unaCuenta.saldo + monto;

            if (unaCuenta is CajaAhorro) {
                CajaAhorroBLL.Current.Update(unaCuenta as CajaAhorro);
            }
            if (unaCuenta is Wallet) {
                WalletBLL.Current.Update(unaCuenta as Wallet);
            }
        }

        public void Extraer(Cuenta unaCuenta, float monto) {
            if (unaCuenta == null)
                throw new Exception("Debe Seleccionar una cuenta");
            if (unaCuenta.saldo < monto)
            {
                throw new Exception("El saldo no es suficiente");
            }
            else
            {
                unaCuenta.saldo = unaCuenta.saldo - monto;
                if (unaCuenta is CajaAhorro)
                {
                    CajaAhorroBLL.Current.Update(unaCuenta as CajaAhorro);
                }
                if (unaCuenta is Wallet)
                {
                    WalletBLL.Current.Update(unaCuenta as Wallet);
                }
            }
        }

        public void Transferir(Cuenta origen, Cuenta destino, float montoOrigen) { }
    }
}
