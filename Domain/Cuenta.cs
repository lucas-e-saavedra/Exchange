using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Cuenta
    {
        public Guid guid { get; set; }

        public float saldo { get; set; }

        public Moneda moneda { get; protected set; }
    }

    public enum Moneda
    {
        ARS, BTC
    }
}
