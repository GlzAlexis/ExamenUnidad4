using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjercicio2
{
    class Proceso
    {
        private static int Distancia(int[] distancia, bool[] corto, int vertice)  //Aqui se calcula la distancia minima de cada ciudad
        {
            int max = int.MaxValue;
            int min = 0;
            for (int i = 0; i < vertice; i++)
            {
                if (corto[i] == false && distancia[i] <= max)
                {
                    max = distancia[i];
                    min = i;
                }
            }
            return min;
        }
        private static void Despligue(int[] distancia, int vertice)            //Despliega las distancias de las ciudades
        {
            Console.WriteLine("Vertice    Distancia");
            for (int i = 0; i < vertice; i++) { Console.WriteLine("{0}\t    {1}", (i + 1), distancia[i]); }
        }
        public void Desplazamiento(int[,] grafo, int origen, int vertice)      //Procedimiento para el calculo de las distancias 
        {
            int[] distancia = new int[vertice];
            bool[] corto = new bool[vertice];
            for(int i = 0; i < vertice; i++)
            {
                distancia[i] = int.MaxValue;
                corto[i] = false;
            }
            distancia[origen] = 0;
            for(int i = 0; i < vertice; i++)
            {
                int j = Distancia(distancia, corto, vertice);
                corto[j] = true;
                for(int k = 0; k < vertice; k++)
                {
                    if (!corto[k] && Convert.ToBoolean(grafo[j, k]) && distancia[j] != int.MaxValue && distancia[j] + grafo[j, k] < distancia[k])
                        distancia[k] = distancia[j] + grafo[j, k];
                }
            }
            Despligue(distancia, vertice);
        }
    }
}
