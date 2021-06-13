using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Wallet: Cuenta
    {
        public String direccion { get; set; }

        public double saldo { get; set; }
    }
}
