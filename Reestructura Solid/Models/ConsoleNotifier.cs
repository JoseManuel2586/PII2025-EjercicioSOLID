﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Models
{
    internal class ConsoleNotifier: INotifierFat
    {
        public void SendEmail(string to, string subject, string body)
    => Console.WriteLine($"[EMAIL] To:{to} Subj:{subject} Body:{body}");
        public void SendSms(string phone, string message)
            => Console.WriteLine($"[SMS] To:{phone} Msg:{message}");
        public void SendPush(string deviceId, string message)
            => throw new NotSupportedException("Push no está disponible en consola, pero la interfaz lo exige.");
    }
}
