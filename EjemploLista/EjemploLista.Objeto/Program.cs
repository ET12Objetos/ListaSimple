using System;
using System.Collections.Generic;

namespace EjemploLista.Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado1 = new Empleado()
            {
                Id = 1,
                Nombre = "Jose",
                Apellido = "te lo debo",
                Dni = 1000
            };

            empleados.Add(empleado1);
            empleados.Add(new Empleado() { Id = 2, Nombre = "pepito", Apellido = "dasda", Dni = 2000 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Abril", Apellido = "dasda", Dni = 5000 });
            empleados.Add(new Empleado() { Id = 4, Nombre = "mayo", Apellido = "dasda", Dni = 100000 });
            empleados.Add(new Empleado() { Id = 5, Nombre = "pepa", Apellido = "dafsda", Dni = 18800 });

            Console.WriteLine();
            Console.WriteLine("FindAll");
            List<Empleado> res = empleados.FindAll(x => x.Nombre.Length > 5);
            res.ForEach(x => Console.WriteLine(x.Nombre));

            Console.WriteLine();
            Console.WriteLine("Contains");
            res = empleados.FindAll(x => x.Apellido.Contains("f"));
            //res.ForEach(x => Console.WriteLine(x.Nombre));
            Imprimir(res);

            Console.WriteLine();
            Console.WriteLine("Exists");
            bool res2 = empleados.Exists(x => x.Nombre.Contains("A"));
            Console.WriteLine(res2);
        }

        static void Imprimir(List<Empleado> empleado)
        {
            empleado.ForEach(x => {
                Console.WriteLine("Id: {0} Nombre: {1} Apellido: {2} Dni: {3}", x.Id, x.Nombre, x.Apellido, x.Dni);
            });
        }
    }
}
