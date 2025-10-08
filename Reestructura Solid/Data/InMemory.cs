using PII2025_EjercicioSOLID.Reestructura_Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_EjercicioSOLID.Reestructura_Solid.Data
{
    internal class InMemory
    {
        private static readonly List<Student> _students = new List<Student>();
        private static readonly List<Course> _courses = new List<Course>();
        private static readonly List<Enrollments> _enrollments = new List<Enrollments>();

        public static IReadOnlyList<Student> Students { get { return _students; } }
        public static IReadOnlyList<Course> Courses { get { return _courses; } }
        public static IReadOnlyList<Enrollments> Enrollments { get { return _enrollments; }


    }
}
