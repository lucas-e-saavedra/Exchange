using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;


namespace DAL.Repositories.SqlServer
{
    class TransferenciaRepository : IGenericRepository<Transferencia>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transferencia> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transferencia GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Transferencia obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Transferencia obj)
        {
            throw new NotImplementedException();
        }
    }
}
