using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Models
{
    internal class CryptoPayment : PaymentBase
    {
        public override bool Pay(decimal amount)
        {
            if (amount != Math.Truncate(amount))
                throw new InvalidOperationException("Crypto solo admite montos enteros (oculto).");
            Console.WriteLine($"[CRYPTO] Hash ok por {amount:C}");
            return true;
        }
    }
}
