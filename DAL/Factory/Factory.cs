using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.SqlServer;
using System.Configuration;

namespace DAL.Factory
{
    public sealed class Factory
    {

        #region Singleton
        private readonly static Factory _instance = new Factory();
        
        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
        }
        #endregion

        public IGenericRepository<CajaAhorro> GetCajaAhorroRepository()
        {
            return new CajaAhorroRepository();
        }

        public IGenericRepository<Wallet> GetWalletRepository()
        {
            return new WalletRepository();
        }

        public IGenericRepository<Deposito> GetDepositoRepository()
        {
            return new DepositoRepository();
        }
        public IGenericRepository<Extraccion> GetExtraccionRepository()
        {
            return new ExtraccionRepository();
        }

        public IGenericRepository<Transferencia> GetTransferenciaRepository()
        {
            return new TransferenciaRepository();
        }
    }
}
