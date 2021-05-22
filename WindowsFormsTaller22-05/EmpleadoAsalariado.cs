using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTaller22_05
{
    public class EmpleadoAsalariado : Empleado
    {
        
        public override void CalculaSalario(double SA, double SH, int HT)
        {
            // SA = Salario
            // SH = 0
            // HT = 0
            Sueldo = SA;
        }
    }
}