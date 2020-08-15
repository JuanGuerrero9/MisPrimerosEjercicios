using SegundoEjercicio;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace SegundoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Agregue el nombre y el apellido del empleado al que quiere conocer su tiempo de vida");
            string fecha1 = Console.ReadLine();
            Dictionary<string, Empleados> evaluacion = new Dictionary<string, Empleados>();
            Empleados p1 = new Empleados("Juan", "Guerrero", new DateTime(1996, 07, 09), new DateTime(2020, 08, 12));


            Empleados p2 = new Empleados("Edwin", "Guerrero", new DateTime(1975, 03, 21), new DateTime(2020, 08, 12));
            Empleados p3 = new Empleados("Juan Carlos", "Guerrero", new DateTime(1974, 10, 09), new DateTime(2020, 08, 12));
            Empleados p4 = new Empleados("Esther", "Ruiz", new DateTime(1957, 06, 25), new DateTime(2020, 08, 12));

            evaluacion.Add($"{p1.NombreEmpleado} {p1.ApellidoEmpleado}", p1);
            evaluacion.Add($"{p2.NombreEmpleado} {p2.ApellidoEmpleado}", p2);
            evaluacion.Add($"{p3.NombreEmpleado} {p3.ApellidoEmpleado}", p3);
            evaluacion.Add($"{p4.NombreEmpleado} {p4.ApellidoEmpleado}", p4);

            string evaluacion1 = $"{(evaluacion[$"{fecha1}"].FechaInicio).ToString("dd/MM/yyyy")}";
            string evaluacion2 = $"{(evaluacion[$"{fecha1}"].FechaFinal).ToString("dd/MM/yyyy")}";

            int dias = Int32.Parse(evaluacion1.Substring(0, 2));
            int meses = Int32.Parse(evaluacion1.Substring(3, 2));
            int anos = Int32.Parse(evaluacion1.Substring(6, 4));

            int dias2 = Int32.Parse(evaluacion2.Substring(0, 2));
            int meses2 = Int32.Parse(evaluacion2.Substring(3, 2));
            int anos2 = Int32.Parse(evaluacion2.Substring(6, 4));

            int diasLabor = 0;
            int mesesLabor = 0;
            int anosLabor = 0;
            int mes = 30;
            int Anos = 12;
            int total = 365;


            // PARA DIAS!!!

            if (dias > dias2) diasLabor += (mes - dias) + dias2;
            else diasLabor += dias2 - dias;

            if (meses > meses2) diasLabor += ((Anos - meses) + (meses2 - 1)) * mes;
            else diasLabor += (meses2 - meses) * mes;

            while ((anos2 - 1) > anos)
            {
                diasLabor += total;
                anos++;

            }


            // ----------------------------------->>>>>


            anos = Int32.Parse(evaluacion1.Substring(6, 4));



            // PARA MES

            if (meses > meses2) mesesLabor += (Anos - meses) + (meses2 - 1);
            else mesesLabor += (meses2 - meses);

            while ((anos2 - 1) > anos)
            {
                mesesLabor += Anos;
                anos++;

            }

            anos = Int32.Parse(evaluacion1.Substring(6, 4));

            // ----------------------------------->>>>>




            // PARA ANO!!!

            while ((anos2) > anos)
            {
                anosLabor += 1;
                anos++;

            }

            // ----------------------------------->>>>>


            Console.WriteLine($"Los dias vividos son: {diasLabor}");
            Console.WriteLine($"Los meses vividos son: {mesesLabor}");
            Console.WriteLine($"Los anos vividos son: {anosLabor}");

        }
    }


    class Empleados
    {

       public Empleados(string nombre, string edad, DateTime fechaInicio, DateTime fechaFinal)
        {
            this.nombreEmpleado = nombre;
            this.apellidoEmpleado = edad;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;

        }

        public int calculoEdad(DateTime num1, DateTime num2)
        {

            return 0;
        }

        private string nombreEmpleado;
        private string apellidoEmpleado;
        private DateTime fechaInicio;
        private DateTime fechaFinal;



        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
    }

    abstract class HallarDias
    {

        public abstract int calculoEdad();
    }


}
