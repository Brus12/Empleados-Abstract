using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTaller22_05
{
    public class EmpleadoPorComision : Empleado
    {
        public override void CalculaSalario(double SA, double SH, int HT)
        {
            //SA = Tarifas de Comision
            //SH Ventas Brutas
            // HT =0
            Sueldo = SA * SH ;
        }
    }
}