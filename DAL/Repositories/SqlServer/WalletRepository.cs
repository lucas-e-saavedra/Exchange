using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;
using DAL.Repositories.SqlServer.Adapters;

namespace DAL.Repositories.SqlServer
{
    class WalletRepository : IGenericRepository<Wallet>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Wallet] (Id, Direccion, Saldo) VALUES (@Id, @Direccion, @Saldo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Wallet] SET Direccion = @Direccion, Saldo = @Saldo WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Wallet] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, Direccion, Saldo FROM [dbo].[Wallet] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, Direccion, Saldo FROM [dbo].[Wallet]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wallet> GetAll()
        {
            List<Wallet> allItems = new List<Wallet>();
            using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    allItems.Add(WalletAdapter.Current.Adapt(values));
                }
            }
            return allItems;
        }

        public Wallet GetOne(Guid id)
        {
            using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", id.ToString()) }))
            {
                if (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    return WalletAdapter.Current.Adapt(values);
                }
            }
            return null;
        }

        public void Insert(Wallet obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Direccion", obj.direccion),
                        new SqlParameter("@Saldo", obj.saldo)});
        }

        public void Update(Wallet obj)
        {
            SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Direccion", obj.direccion),
                        new SqlParameter("@Saldo", obj.saldo)});
        }
    }
}
