using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer.Adapters
{

    public sealed class CajaAhorroAdapter: IEntityAdapter<CajaAhorro>
    {
        private readonly static CajaAhorroAdapter _instance = new CajaAhorroAdapter();

        public static CajaAhorroAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private CajaAhorroAdapter()
        {
            //Implent here the initialization of your singleton
        }

        public CajaAhorro Adapt(object[] values)
        {
            return new CajaAhorro()
            {
                guid = Guid.Parse(values[0].ToString()),
                cbu = values[1].ToString(),
                cuit = values[2].ToString(),
                saldo = float.Parse(values[3].ToString())
            };
        }
    }

}
