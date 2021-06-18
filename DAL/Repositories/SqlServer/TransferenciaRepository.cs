using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;
using DAL.Repositories.SqlServer.Adapters;

namespace DAL.Repositories.SqlServer
{
    class TransferenciaRepository : IGenericRepository<Transferencia>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Transferencia] (Id, CuentaOrigen, MontoDebitado, MonedaDebitada, CuentaDestino, MontoAcreditado, MonedaAcreditada) VALUES (@Id, @CuentaOrigen, @MontoDebitado, @MonedaDebitada, @CuentaDestino, @MontoAcreditado, @MonedaAcreditada)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Transferencia] SET CuentaOrigen = @CuentaOrigen, MontoDebitado = @MontoDebitado, MonedaDebitada = @MonedaDebitada, CuentaDestino = @CuentaDestino, MontoAcreditado = @MontoAcreditado, MonedaAcreditada = @MonedaAcreditada) WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Transferencia] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, CuentaOrigen, MontoDebitado, MonedaDebitada, CuentaDestino, MontoAcreditado, MonedaAcreditada FROM [dbo].[Transferencia] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, CuentaOrigen, MontoDebitado, MonedaDebitada, CuentaDestino, MontoAcreditado, MonedaAcreditada FROM [dbo].[Transferencia]";
        }
        #endregion



        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transferencia> GetAll()
        {
            List<Transferencia> allItems = new List<Transferencia>();
            using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
            {
                while (dr.Read())
                {
                    //En este caso tendremos un solo registro...
                    object[] values = new object[dr.FieldCount];
                    dr.GetValues(values);
                    allItems.Add(TransferenciaAdapter.Current.Adapt(values));
                }
            }
            return allItems;
        }

        public Transferencia GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Transferencia obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@CuentaOrigen", obj.cuentaOrigen.guid),
                        new SqlParameter("@MontoDebitado", obj.montoDebitado),
                        new SqlParameter("@MonedaDebitada", obj.monedaDebitada.ToString()),
                        new SqlParameter("@CuentaDestino", obj.cuentaDestino.guid),
                        new SqlParameter("@MontoAcreditado", obj.montoAcreditado),
                        new SqlParameter("@MonedaAcreditada", obj.monedaAcreditada.ToString())});
        }

        public void Update(Transferencia obj)
        {
            throw new NotImplementedException();
        }
    }
}
