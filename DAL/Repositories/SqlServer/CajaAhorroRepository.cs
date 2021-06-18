using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;
using DAL.Repositories.SqlServer.Adapters;

namespace DAL.Repositories.SqlServer
{
    class CajaAhorroRepository : IGenericRepository<CajaAhorro>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[CajaAhorro] (id, cbu, cuit, saldo) VALUES (@id, @cbu, @cuit, @saldo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[CajaAhorro] SET cbu = @Cbu, cuit = @Cuit, saldo = @Saldo WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[CajaAhorro] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, cbu, cuit, saldo FROM [dbo].[CajaAhorro] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, cbu, cuit, saldo FROM [dbo].[CajaAhorro]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CajaAhorro> GetAll()
        {
            List<CajaAhorro> allItems = new List<CajaAhorro>();
            using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    allItems.Add(CajaAhorroAdapter.Current.Adapt(values));
                }
            }
            return allItems;
        }

        public CajaAhorro GetOne(Guid id)
        {
            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", id) }))
            {
                if (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    return CajaAhorroAdapter.Current.Adapt(values);
                }
            }
            return null;
        }

        public void Insert(CajaAhorro obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] { 
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cbu", obj.cbu),
                        new SqlParameter("@Cuit", obj.cuit),
                        new SqlParameter("@Saldo", obj.saldo)});
        }

        public void Update(CajaAhorro obj)
        {
            SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cbu", obj.cbu),
                        new SqlParameter("@Cuit", obj.cuit),
                        new SqlParameter("@Saldo", obj.saldo)});
        }
    }
}
