using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTaller22_05
{
    public abstract class Empleado
    {
        public double SalarioSemanal;
        public double SueldoXHoras;
        public double Sueldo;
        public double SueldoBase;
        public double VentasBrutas;

        public abstract void CalculaSalario(double SA, double SH, int HT);
        //SA sueldo Empleado Asalariado
        // SH sueldo hora Empleado por Horas
        // HT horas trabajadas de empleado por horas
    }
}