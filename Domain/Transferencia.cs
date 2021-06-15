using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Transferencia
    {
        public Guid guid { get; set; }
        public Cuenta cuentaOrigen { get; set; }
        public float montoDebitado { get; set; }
        public Moneda monedaDebitada { get; set; }
        public Cuenta cuentaDestino { get; set; }
        public float montoAcreditado { get; set; }
        public Moneda monedaAcreditada { get; set; }

    }
}
