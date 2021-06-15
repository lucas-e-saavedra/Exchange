using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public sealed class WalletBLL 
    {
        #region Singleton
        private readonly static WalletBLL  _instance = new WalletBLL ();

        public static WalletBLL  Current
        {
            get
            {
                return _instance;
            }
        }
        private WalletBLL()
        {
            //Implement here the initialization code
        }

        #endregion
            
        
        public void Add(Wallet obj)
        {
            DAL.Factory.Factory.Current.GetWalletRepository().Insert(obj);
        }


        internal void Update(Wallet obj)
        {
            DAL.Factory.Factory.Current.GetWalletRepository().Update(obj);
        }

        public IEnumerable<Wallet> GetAll()
        {
            return DAL.Factory.Factory.Current.GetWalletRepository().GetAll();
        }

        public Wallet GetOne(Guid id)
        {
            return DAL.Factory.Factory.Current.GetWalletRepository().GetOne(id);
        }

    }

}
