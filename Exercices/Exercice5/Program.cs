using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignBooleansImplicity();
            FailFast();
            ReturnEarly();
        }

        static void AssignBooleansImplicity()
        {
            bool IsAccepted = false;
            int age = 25;
            int MayorAge = 18;

            if (age > MayorAge)
            {
                IsAccepted = true;
            }
            else
            {
                IsAccepted = false;
            }
        }

        static void FailFast()
        {
            string nombreAlumno = string.Empty;
            string ApellidoAlumno = string.Empty;
            bool isAccepted = false;

            if (string.IsNullOrEmpty(nombreAlumno))
            {
                if (string.IsNullOrEmpty(ApellidoAlumno))
                {
                    isAccepted = true;
                }
                else
                {
                    throw new Exception("El Apellido del alumno es requerido.");
                }
            }
            else
            {
                throw new Exception("El Nombre del alumno es requerido.");
            }

        }

        static bool ReturnEarly()
        {

            int NotaExamen = 14;
            int NotaTrabajo = 16;
            int NotaEvaluacionOral = 13;

            bool isValid = false;

            const int MinNotaExamen = 11;
            const int MinNotaTrabajos = 15;
            const int MinNotaEvaluacionOral = 12;

            if (NotaEvaluacionOral >= MinNotaEvaluacionOral)
            {
                if (NotaTrabajo >= MinNotaTrabajos)
                {
                    if (NotaExamen >= MinNotaExamen)
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }

    }
}
