using System;
namespace Deber
{
    //ISAAC HARO
    //ESTRUCTURA DE DATOS 27/09/2020
    class Pila//CLASE PILA
    {
        private char[] elemento = new char[20];//ATRIBUTOS
        private int tope;
        public Pila()//FUNCION PILA PARA INICIALIZAR TODA LA PILA
        {
            for (int i = 0; i < 20; i++)
            {
                elemento[i] = '0';// INICIALIZACION EN 0
                tope = -1;
            }
        }
        public int EntregaTope()//ENTREGA EL VALOR DE TOPE
        {
            return tope;
        }
        public void Push(string a, int b)//PUSH
        {
            char[] c;
            c= a.ToCharArray();
            elemento[tope + 1] = c[b];//GUARDA LOS DATOS EN LA PILA
            tope += 1;
        }
        public void Pop(string a, int b)//POP
        {
            char[] c;
            c = a.ToCharArray();
            if (tope < 0)
            {
                tope++;//SI LA PILA CONTIENE DATOS IMPRIMIR EL ERROR
            }
            if (elemento[tope]=='('&&c[b]==')'|| elemento[tope] == '[' && c[b] == ']'|| elemento[tope] == '{' && c[b] == '}')
            {
                elemento[tope] = '0';//QUITA LOS DATOS DE LA PILA
                tope -= 1;
            } 
        }
    }
    class Program//CLASE PROGRAM
    {
        static void Main(string[] args)//PROGRAMA PRINCIPAL
        {
            Console.Title = "Stack Verificador de ecuaciones";//TITULO DE LA CONSOLA
            Console.BackgroundColor = ConsoleColor.DarkBlue;//COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            string ingreso;//VARIABLE STRING
            Pila Mi_Pila = new Pila();//CLASE PILA
            Console.WriteLine("Ingrese una ecuacion");
            ingreso = Console.ReadLine();//GUARDAMOS EL INGRESO
            for(int i = 0; i < ingreso.Length; i++)//BUCLE PARA LOS PARAMETROS ABIERTOS Y CERRADOS
            {
                if (ingreso.Substring(i,1)=="("|| ingreso.Substring(i, 1) == "["|| ingreso.Substring(i, 1) == "{")
                {
                    Mi_Pila.Push(ingreso, i);
                }
                else if (ingreso.Substring(i, 1) == ")" || ingreso.Substring(i, 1) == "]" || ingreso.Substring(i, 1) == "}")
                {
                    Mi_Pila.Pop(ingreso, i);
                }
            }
            if (Mi_Pila.EntregaTope()==-1)//SI TOPE NO TIENE VALORES LA ECUACION ESTA CORRECTA
            {
                Console.WriteLine("La ecuacion esta balanceada");
            }
            else//SI PILA TIENE VALORES IMPRIME EL ERROR
            {
                Console.WriteLine("La ecuacion no esta balanceada");
            }
        }
    }
}
