using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer.Adapters
{

    public sealed class TransferenciaAdapter: IEntityAdapter<Transferencia>   {
        private readonly static TransferenciaAdapter _instance = new TransferenciaAdapter();

        public static TransferenciaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private TransferenciaAdapter()
        {
            //Implent here the initialization of your singleton
        }

        public Transferencia Adapt(object[] values)
        {
            Moneda monedaOrigen = (Moneda)Enum.Parse(typeof(Moneda), values[3].ToString());
            Guid guidCuentaOrigen = Guid.Parse(values[1].ToString());
            Cuenta _cuentaOrigen = null;
            switch (monedaOrigen)
            {
                case Moneda.ARS:
                    _cuentaOrigen = new CajaAhorroRepository().GetOne(guidCuentaOrigen);
                    break;
                case Moneda.BTC:
                    _cuentaOrigen = new WalletRepository().GetOne(guidCuentaOrigen);
                    break;
            }

            Moneda monedaDestino = (Moneda)Enum.Parse(typeof(Moneda), values[6].ToString());
            Guid guidCuentaDestino = Guid.Parse(values[4].ToString());
            Cuenta _cuentaDestino = null;
            switch (monedaDestino)
            {
                case Moneda.ARS:
                    _cuentaDestino = new CajaAhorroRepository().GetOne(guidCuentaDestino);
                    break;
                case Moneda.BTC:
                    _cuentaDestino = new WalletRepository().GetOne(guidCuentaDestino);
                    break;
            }
            return new Transferencia() 
            {
                guid = Guid.Parse(values[0].ToString()),
                cuentaOrigen = _cuentaOrigen,
                montoDebitado = float.Parse(values[2].ToString()),
                monedaDebitada = monedaOrigen,
                cuentaDestino = _cuentaDestino,
                montoAcreditado = float.Parse(values[5].ToString()),
                monedaAcreditada = monedaDestino
            };

        }
    }

}
