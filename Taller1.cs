using System;
using System.Collections.Generic;

namespace miPrimerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asigne una fecha Inicio asi: dd/mm/aaaa");
            string ArrayFechas1 = Console.ReadLine();


            Console.WriteLine("Asigne una fecha fin asi: dd/mm/aaaa");
            string ArrayFechas2 = Console.ReadLine();


            Empleados Empleado1 = new Empleados(ArrayFechas1, ArrayFechas2);

            Console.WriteLine($"Los dias laborados son: {Empleado1.CalculoDias()}");

        }



         

    }


   

    class Empleados
    {
        public Empleados(string FechaInicio, string FechaFin)
        {
            this.Inicio = FechaInicio;
            this.Fin = FechaFin;


        }


        public int CalculoDias()
        {
            int dias = Int32.Parse(Inicio.Substring(0, 2));
            int meses = Int32.Parse(Inicio.Substring(3, 2));
            int anos = Int32.Parse(Inicio.Substring(6, 4));

            int dias2 = Int32.Parse(Fin.Substring(0, 2));
            int meses2 = Int32.Parse(Fin.Substring(3, 2));
            int anos2 = Int32.Parse(Fin.Substring(6, 4));

            int diasLabor = 0;
            int mes = 30;
            int Anos = 12;
            int total = 365;

            if (dias > dias2) diasLabor += (mes - dias) + dias2;
            else diasLabor += dias2 - dias;

            if (meses > meses2) diasLabor += ((Anos - meses) + (meses2-1)) * mes;
            else diasLabor += (meses2-meses) * mes;

            while((anos2-1) > anos)
            {
                diasLabor += total;
                anos++;

            }




            return diasLabor;

        }

        private string Inicio;
        private string Fin;

        public string Inicio1 { get => Inicio; set => Inicio = value; }
        public string Fin1 { get => Fin; set => Fin = value; }
    }


}
