using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;
using Domain;

namespace DAL.Repositories.SqlServer.Adapters
{

    public sealed class WalletAdapter: IEntityAdapter<Wallet>
    {
        private readonly static WalletAdapter _instance = new WalletAdapter();

        public static WalletAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private WalletAdapter()
        {
            //Implent here the initialization of your singleton
        }

        public Wallet Adapt(object[] values)
        {
            return new Wallet() {
                guid = Guid.Parse(values[0].ToString()),
                direccion = values[1].ToString(),
                saldo = float.Parse(values[2].ToString())
            };
        }
    }

}
