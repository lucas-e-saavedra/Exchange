using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class OperacionSimple
    {
        public Guid guid { get; set; }
        public Cuenta cuenta { get; set; }
        public float monto { get; set; }
        public Moneda moneda { get; set; }
    }
}
