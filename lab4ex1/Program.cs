using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
             functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul.*/


            Console.WriteLine("Introduceti numar elemente vector: ");

            int elementeVector = int.Parse(Console.ReadLine());


            int[] dimensiuneVector = AfisareVector(elementeVector);


            InversareElementeVector(dimensiuneVector);






            static int[] AfisareVector(int dimensiuneVector)
            {

                int[] numereVector = new int[dimensiuneVector];

                Console.WriteLine("\n" + "Introduceti elementele vectorului:");

                for (int i = 0; i < dimensiuneVector; i++)
                {
                    numereVector[i] = int.Parse(Console.ReadLine());
                }

                return numereVector;
            }




            static void InversareElementeVector(int[] elementeVector)
            {
                int[] listaElementeVector = elementeVector;

                Array.Reverse(listaElementeVector);

                Console.Write("\n"+ "Vectorul inversat de numere intregi este: " + "\n");
                foreach (int i in listaElementeVector)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}