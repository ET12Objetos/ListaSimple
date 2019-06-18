using System;
using System.Collections.Generic;

namespace EjemploLista.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion lista
            List<int> numeros;

            //Intanciar lista
            numeros = new List<int>();

            //Declaracion e instanciacion de lista de numeros enteros
            List<int> numeros2 = new List<int>()
            {
                2, 3, 5, 6, 7
            };

            //Ciclo de iteracion ForEach, lectura lista
            foreach (int num in numeros2)
            {
                Console.WriteLine(num);
            }

            //Agrega elementos a la lista
            numeros.Add(40);
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(40);
            numeros.Add(10);
            numeros.Add(60);
            numeros.Add(40);
            numeros.Add(20);
            numeros.Add(21);
            numeros.Add(15);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            //Elimina todos los elementos de la lista
            numeros.Clear();

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            //Método Contains determina si un elemento se encuentra presente en la lista numeros
            Console.WriteLine("Contains: {0}", numeros.Contains(20));

            //Método Exists determina si existe un elemento que satisface la/s condiciones
            Console.WriteLine(numeros.Exists(x => x > 50));
            Console.WriteLine("Exists 0 en numeros: {0}", numeros.Exists(x => x < 0));
            Console.WriteLine("Exists > 0 y < 40 en numeros: {0}", numeros.Exists(x => x > 10 && x < 40));

            //Método ForEach realiza una accion para cada elemento de la lista
            numeros.ForEach(x => {
                Console.WriteLine(x);
            });

            //Método Find, encuentra el primer elemento que cumpla con la condición
            int num2 = numeros.Find(x => x == 20);
            Console.WriteLine("Find se encuentra primer numero '20' {0}", num2);

            //Método IndexOf, encuentra la primer ocurrencia de un elemento especifico retorna índice
            int pos = numeros.IndexOf(num2);
            Console.WriteLine("Indice 20 en numeros: {0}", pos);

            //Método FindLast, encuentra el primer elemento que cumpla con la condición
            int num3 = numeros.FindLast(x => x == 20);
            Console.WriteLine("Find se encuentra ultimo numero '20' {0}", num3);

            //Método LastIndexOf encuentra la ultima ocurrencia de un elemento especifico retorna índice
            int pos2 = numeros.LastIndexOf(num3);
            Console.WriteLine("Indice 20 en numeros: {0}", pos2);

            //Método FindAll, encuentra todos los elementos que cumplan con la condición especificada
            List<int> res = numeros.FindAll(x => x > 15);

            Console.WriteLine();
            Console.WriteLine("FindAll");
            res.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("FindIndex");
            int pos4 = numeros.FindIndex(1, x => x == 40);
            Console.WriteLine("Indice '40' en numeros {0}", pos4);

            Console.WriteLine();
            Console.WriteLine("FindLastIndex");
            int pos5 = numeros.FindLastIndex(7, x => x == 40);
            Console.WriteLine("Indice '40' en numeros {0}", pos5);

            //Método Insert, inserta un elemento en la posicion espeficada por parametro
            Console.WriteLine();
            Console.WriteLine("Insert");
            numeros.Insert(3, 1000);
            numeros.ForEach(x => Console.WriteLine(x));

            //Método Remove, elimina un elemento espeficado por parámetro
            Console.WriteLine();
            Console.WriteLine("Remove");
            numeros.Remove(1000);
            numeros.ForEach(x => Console.WriteLine(x));

            //Método RemoveAt, elimina un elemento dada una posición especificada
            Console.WriteLine();
            Console.WriteLine("RemoveAt");
            numeros.RemoveAt(4);
            numeros.ForEach(x => Console.WriteLine(x));

            //Método RemoveAll, elimina todos los elementos que cumplan con una condicion especifica
            Console.WriteLine();
            Console.WriteLine("RemoveAll");
            numeros.RemoveAll(x => x % 2 == 0);
            numeros.ForEach(x => Console.WriteLine(x));

            //Método Sort, ordena los elementos segun un criterio
            Console.WriteLine();
            Console.WriteLine("Sort");
            numeros.Sort();
            numeros.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("Elemento menor y mayor de la lista");
            numeros.Sort();
            Console.WriteLine(numeros[0]); //menor
            Console.WriteLine(numeros[numeros.Count - 1]); //mayor

            //Método Reverse, invierte el orden de los elementos
            Console.WriteLine();
            Console.WriteLine("Reverse");
            numeros.Sort();
            numeros.Reverse();
            Console.WriteLine(numeros[0]); //mayor
        }
    }
}