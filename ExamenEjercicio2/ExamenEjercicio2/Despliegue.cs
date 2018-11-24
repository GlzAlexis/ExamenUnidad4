using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjercicio2
{
    class Despliegue
    {
        public void Menu()
        {
            Proceso proceso = new Proceso();
        int[,] grafo =
        {
           {0, 349, 957, 1855, 0, 2534, 0, 0},              //1 -> San Francisco 
           {349, 0,   834, 0,  0, 2451, 0, 0},              //2 -> LosAngeles
           {957, 834, 0,  908, 0, 0, 0, 0},                 //3 -> =Denver
           {1855, 0,  908, 0, 860, 722,  606, 0},           //4 -> Chicago               \\ Grafo donde esta la distancia de cada ciudad a otras ciudades
           {0, 0, 0, 860, 0, 191, 0, 0},                    //5 -> Boston
           {2534, 2451, 0, 722, 191, 0, 760, 1090},         //6 -> NuevaYork
           {0, 0, 0, 606, 0,  760, 0, 595},                 //7 -> Atlanta
           {0, 0, 0, 0, 0, 1090, 595, 0}                    //8 -> Miami
        };
            string opc = "";
            Console.Write("1.- Boston a Los Angeles \n2.- Nueva York a San Francisco \n3.- Atlanta a San Francisco 4.- Denver a Nueva York \n\nIngrese la opcion de la distancia que desea saber: ");
            opc = Console.ReadLine();
            if (opc == "1")
            {
                Console.WriteLine("\nDe Boston a Los Angeles");
                Console.WriteLine("1 -> San Francisco \n2 -> Los Angeles \n3 -> Denver \n4 -> Chicago \n5 -> Boston \n6 -> Nueva York \n7 -> Atlanta \n8 -> Miami");
                Console.WriteLine("\nLa ruta mas corta es por la ciudad 2\n");
                proceso.Desplazamiento(grafo, 4, 8);
                Console.ReadKey();
            }
            else if (opc == "2")
            {
                Console.WriteLine("\nDe Nueva York a San Francisco");
                Console.WriteLine("1 -> San Francisco \n2 -> Los Angeles \n3 -> Denver \n4 -> Chicago \n5 -> Boston \n6 -> Nueva York \n7 -> Atlanta \n8 -> Miami");
                Console.WriteLine("\nLa ruta mas corta es por la ciudad 1\n");
                proceso.Desplazamiento(grafo, 5, 8);
                Console.ReadKey();
            }
            else if (opc == "3")
            {
                Console.WriteLine("\nDe Atlanta a San Francisco");
                Console.WriteLine("1 -> San Francisco \n2 -> Los Angeles \n3 -> Denver \n4 -> Chicago \n5 -> Boston \n6 -> Nueva York \n7 -> Atlanta \n8 -> Miami");
                Console.WriteLine("\nLa ruta mas corta es por la ciudad 1\n");
                proceso.Desplazamiento(grafo, 6, 8);
                Console.ReadKey();
            }
            else if (opc == "4")
            {
                Console.WriteLine("\nDe Denver a Nueva York");
                Console.WriteLine("1 -> San Francisco \n2 -> Los Angeles \n3 -> Denver \n4 -> Chicago \n5 -> Boston \n6 -> Nueva York \n7 -> Atlanta \n8 -> Miami");
                Console.WriteLine("\nLa ruta mas corta es por la ciudad 6\n");
                proceso.Desplazamiento(grafo, 2, 8);
                Console.ReadKey();
            }
        }
    }
}
