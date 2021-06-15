using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Wallet: Cuenta
    {
        public String direccion { get; set; }

        public Wallet()
        {
            moneda = Moneda.BTC;
        }
    }
}
