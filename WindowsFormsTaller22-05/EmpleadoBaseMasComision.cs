using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTaller22_05
{
    public class EmpleadoBaseMasComision : Empleado
    {
        public override void CalculaSalario(double SA, double SH, int HT)
        {
            //SA = Tarifas de Comision
            //SH = Salario Base
            //HT = Ventas Brutas
            Sueldo = (SA * HT) + SH;
        }
    }
}