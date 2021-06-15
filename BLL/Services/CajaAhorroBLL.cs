using System;
using System.Collections.Generic;

using Domain;

namespace BLL.Services
{

    public sealed class CajaAhorroBLL
    {
        private readonly static CajaAhorroBLL _instance = new CajaAhorroBLL();

        public static CajaAhorroBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private CajaAhorroBLL()
        {
            //Implent here the initialization of your singleton
        }

        public void Add(CajaAhorro obj)
        {
            DAL.Factory.Factory.Current.GetCajaAhorroRepository().Insert(obj);
        }


        internal void Update(CajaAhorro obj)
        {
            DAL.Factory.Factory.Current.GetCajaAhorroRepository().Update(obj);
        }

        public IEnumerable<CajaAhorro> GetAll()
        {
            return DAL.Factory.Factory.Current.GetCajaAhorroRepository().GetAll();
        }

        public CajaAhorro GetOne(Guid id)
        {
            return DAL.Factory.Factory.Current.GetCajaAhorroRepository().GetOne(id);
        }
    }
}
