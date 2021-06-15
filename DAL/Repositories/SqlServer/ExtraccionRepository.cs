using DAL.Contracts;
using DAL.Tools;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{
    class ExtraccionRepository : IGenericRepository<Extraccion>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Extraccion] (Id, Cuenta, Monto, Moneda) VALUES (@Id, @Cuenta, @Monto, @Moneda)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Extraccion] SET Cuenta = @Cuenta, Monto = @Monto, Moneda = @Moneda WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Extraccion] WHERE  = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT , Id, Cuenta, Monto, Moneda FROM [dbo].[Extraccion] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT  Id, Cuenta, Monto, Moneda FROM [dbo].[Extraccion]";
        }

        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Extraccion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Extraccion GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Extraccion obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cuenta", obj.cuenta.guid),
                        new SqlParameter("@Monto", obj.monto),
                        new SqlParameter("@Moneda", obj.moneda.ToString())});
        }

        public void Update(Extraccion obj)
        {
            throw new NotImplementedException();
        }


    }
}
