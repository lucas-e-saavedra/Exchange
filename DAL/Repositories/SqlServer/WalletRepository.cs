using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;

namespace DAL.Repositories.SqlServer
{
    class WalletRepository : IGenericRepository<Wallet>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wallet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Wallet GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Wallet obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Wallet obj)
        {
            throw new NotImplementedException();
        }
    }
}
