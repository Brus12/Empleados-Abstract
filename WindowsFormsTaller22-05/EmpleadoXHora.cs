using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTaller22_05
{
    public class EmpleadoXHora : Empleado
    {
        public override void CalculaSalario(double SA, double SH, int HT)
        {
            // SA = 0
            // SH = Sueldo Hora
            // HT = Horas Trabajadas
            if (HT<=40)
            {
                Sueldo = SH * HT;
            }
            if (HT>40)
            {
                Sueldo = 40 * SH + (HT-40) * SH * 1.5;
            }
        }
    }
}