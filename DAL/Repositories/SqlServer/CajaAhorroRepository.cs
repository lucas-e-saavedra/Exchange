using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;

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


        void IGenericRepository<CajaAhorro>.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CajaAhorro> IGenericRepository<CajaAhorro>.GetAll()
        {
            List<CajaAhorro> allItems = new List<CajaAhorro>();
            using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);

                    CajaAhorro unaCajaAhorro = new CajaAhorro();
                    unaCajaAhorro.guid = Guid.Parse(values[0].ToString());
                    unaCajaAhorro.cbu = values[1].ToString();
                    unaCajaAhorro.cuit = values[2].ToString();
                    unaCajaAhorro.saldo = float.Parse(values[3].ToString());
                    allItems.Add(unaCajaAhorro);
                }
            }
            return allItems;
        }

        CajaAhorro IGenericRepository<CajaAhorro>.GetOne(Guid id)
        {
            throw new NotImplementedException();

            /*using (var dr = SqlHelper.ExecuteReader(SelectOneStatement, System.Data.CommandType.Text,
                                                    new SqlParameter[] { new SqlParameter("@IdAddress", id) }))
            {
                if (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);

                    //DATA MAPPER IdAddress, Street, Number, City
                    /*address = new Address();
                    address.IdAddress = Guid.Parse(values[0].ToString());
                    address.Street = values[1].ToString();
                    address.Number = int.Parse(values[2].ToString());
                    address.City = values[3].ToString();* /
                }
            }*/
        }

        void IGenericRepository<CajaAhorro>.Insert(CajaAhorro obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] { 
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cbu", obj.cbu),
                        new SqlParameter("@Cuit", obj.cuit),
                        new SqlParameter("@Saldo", obj.saldo)});
        }

        void IGenericRepository<CajaAhorro>.Update(CajaAhorro obj)
        {
            SqlHelper.ExecuteNonQuery(UpdateStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cbu", obj.cbu),
                        new SqlParameter("@Cuit", obj.cuit),
                        new SqlParameter("@Saldo", obj.saldo)});
        }
    }
}
