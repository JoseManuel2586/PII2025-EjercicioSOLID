using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Models
{
    internal class FileRepository
    {
        public void SaveEnrollment(string id, string studentId, string courseId, decimal finalPrice)
        {
            System.IO.Directory.CreateDirectory("db");
            var line = $"{id};{studentId};{courseId};{finalPrice}";
            System.IO.File.AppendAllLines("db/enrollments.csv", new[] { line });
        }
    }
}
