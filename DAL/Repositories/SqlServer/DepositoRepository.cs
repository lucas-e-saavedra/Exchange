using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;


namespace DAL.Repositories.SqlServer
{
    class DepositoRepository : IGenericRepository<Deposito>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deposito> GetAll()
        {
            throw new NotImplementedException();
        }

        public Deposito GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Deposito obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Deposito obj)
        {
            throw new NotImplementedException();
        }
    }
}
