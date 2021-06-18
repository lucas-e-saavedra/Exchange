using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CajaAhorro: Cuenta
    {
        public String cbu { get; set; }

        public String cuit { get; set; }

        public CajaAhorro() {
            moneda = Moneda.ARS;
        }

        public override string ToString()
        {
            return "CajaAhorro CBU:" + cbu;
        }
    }
}
