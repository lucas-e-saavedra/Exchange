using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;



namespace DAL.Repositories.SqlServer
{
    class ConversionRepository : IGenericRepository<Conversion>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conversion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Conversion GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Conversion obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Conversion obj)
        {
            throw new NotImplementedException();
        }
    }
}
