using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Interfaces
{
    internal interface INotifierFat
    {
        void SendEmail(string to, string subject, string body);
        void SendSms(string phone, string message);
        void SendPush(string deviceId, string message);
    }
}
