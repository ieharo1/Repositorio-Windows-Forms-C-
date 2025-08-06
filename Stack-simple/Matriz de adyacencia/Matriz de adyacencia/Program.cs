using System;
//Isaac Haro
namespace Matriz_de_adyacencia
{
    public class Graph//Clase grafo
    {
        private int n;//int
        private int[,] g = new int[10, 10];//arreglo bidimensional
        public Graph(int x)//agregar datos y constructor
        {
            this.n = x;
        }
        public void displayAdjacencyMatrix()//imprimir la matriz
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" "+g[i,j]);
                }
            }
        }
        public void addEdge(int x, int y)//Agregar la matriz normal
        {
            if ((x >= n) || (y > n))
            {
                Console.WriteLine("Vertice no existe");
            }
            if (x == y)
            {
                Console.WriteLine("Mismo Vertice!");
            }
            else
            {
                g[y, x] = 1;
                g[x, y] = 1;
            }
        }
        public void addEdge(int x,int y, int c)//Agregar la matriz con el peso
        {
            if ((x >= n) || (y > n))
            {
                Console.WriteLine("Vertice no existe");
            }
            if (x == y)
            {
                Console.WriteLine("Mismo vertice!");
            }
            else
            {
                g[y, x] = c;
                g[x, y] = c;
            }
        }
        public void addVertex()//Agregar vertica
        {
            n++;
            for (int i = 0; i < n; i++)
            {
                g[i, n - 1] = 0;
                g[n - 1, i] = 0;
            }
        }
        public void removeVertex(int x)//remover vertice
        {
            if (x > n)
            {
                Console.WriteLine("Vertice no presente!");
                return;
            }
            else
            {
                int i;
                while (x<n)
                {
                    for (i = 0; i < n; i++)
                    {
                        g[i, x] = g[i, x + 1];
                    }
                    for (i = 0; i < n; i++)
                    {
                        g[x, i] = g[x + 1, i];
                    }
                    x++;
                }
                n--;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)//programa principal
        {
            Graph nodo;//Grafo nodo
            Graph nodo2;//Grafo nodo2
            int aristas, vertices, f,h=0;//variables int
            Console.WriteLine("Ingrese cuantas aristas desea: ");//ingreso de datos
            aristas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cuantos vertices o nodos desea: ");
            vertices = int.Parse(Console.ReadLine());
            nodo = new Graph(vertices);
            nodo2=new Graph(vertices);
            string[] split;
            int[] arr = new int[aristas * 3];
            for (int i = 0; i < aristas * 3; i++)
            {
                Console.WriteLine($"Ingrese el peso de su arista, seguido de donde parte, y hacia donde parte su nodo {h+ 1}?\nEjemplo: 2,1,4 ");
                split = Console.ReadLine().Split(",");

                arr[i] = int.Parse(split[0]);
                arr[i + 1] = int.Parse(split[1]);
                arr[i + 2] = int.Parse(split[2]);
                nodo.addEdge(arr[i + 1], arr[i + 2]);
                nodo2.addEdge(arr[i + 1], arr[i + 2], arr[i]);
                h++;
                i = i + 2;
            }
            Console.WriteLine("Su matriz de adyancia es: \n");//Impresion de datos por consola
            nodo.displayAdjacencyMatrix();
            Console.WriteLine();
            Console.WriteLine("Su matriz de adyancia tomando en cuenta los pesos de cada arista es: \n");
            nodo2.displayAdjacencyMatrix();
        }
    }
}
