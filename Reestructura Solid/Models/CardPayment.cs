using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Models
{
    internal class CardPayment: PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine($"[CARD] Cobrado {amount:C}");
            return true;
        }
    }
}
