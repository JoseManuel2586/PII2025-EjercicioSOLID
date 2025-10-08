using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Models
{
    internal class CashPayment: PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine($"[CASH] Registrado {amount:C}");
            return true;
        }
        public override void Refund(decimal amount)
        {
            Console.WriteLine($"[CASH] Refund {amount:C}");
        }
    }
}
