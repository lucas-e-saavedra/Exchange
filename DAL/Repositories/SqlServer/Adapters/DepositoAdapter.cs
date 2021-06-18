using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer.Adapters
{

    public sealed class DepositoAdapter:IEntityAdapter<Deposito>   
    {
        private readonly static DepositoAdapter _instance = new DepositoAdapter();

        public static DepositoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private DepositoAdapter()
        {
            //Implent here the initialization of your singleton
        }

        public Deposito Adapt(object[] values)
        {
            Moneda unaMoneda = (Moneda)Enum.Parse(typeof(Moneda), values[3].ToString());
            Guid guidCuenta = Guid.Parse(values[1].ToString());
            Cuenta unaCuenta = null;
            switch (unaMoneda)
            {
                case Moneda.ARS:
                    unaCuenta = new CajaAhorroRepository().GetOne(guidCuenta);
                    break;
                case Moneda.BTC:
                    unaCuenta = new WalletRepository().GetOne(guidCuenta);
                    break;
            }
            return new Deposito() {
                guid = Guid.Parse(values[0].ToString()),
                cuenta = unaCuenta,
                monto = float.Parse(values[2].ToString()),
                moneda = unaMoneda
            };
        }
    }

}
