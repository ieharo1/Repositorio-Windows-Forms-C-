using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Visible(false);
        }
        private void Visible(bool a)
        {
            lblRMultiplicacion.Visible=a;
            lblRFibonacci.Visible=a;
            lblRFactorial.Visible=a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c, d;
                a = int.Parse(text1.Text);
                b = int.Parse(text2.Text);
                c = int.Parse(text3.Text);
                d = int.Parse(text4.Text);
                lblRFibonacci.Text = "La respuesta de fibonacci es: "+ Fibonacci(a);
                lblRMultiplicacion.Text = "La respuesta de multiplicacion es: " + NumbNatu(b, c);
                lblRFactorial.Text = "La respuesta de factorial es: "+ Fact(d);
            }
            catch(Exception p)
            {
                Console.WriteLine("Su programa no sirve");
            }
            finally
            {
                Visible(true);
            }
        }
        //Funcion Calculo Factorial
        static int Fact(int n)//Funcion factorial
        {
            int x, y;//definicion de variables temporales
            if (n == 0)
                return 1;//Si n es igual a 0 retornamos 1
            else//Si n es diferente de 0 realizamos las operaciones del factorial
            {
                x = n - 1;
                y = Fact(x);
                return (n * y);
            }
        }
        static int NumbNatu(int a, int b)//Funcion Numero Natural
        {
            if (b == 1)//Si b es igual a 1 retornamos a
                return a;
            else//Si b es diferente de 0 retornamos la multiplicacion de uno en uno
                return NumbNatu(a, (b - 1)) + a;
        }
        static int Fibonacci(int a)//Funcion Fibonacci
        {
            if (a==1 || a==0)//Retorna a
                return a;
            else
                return Fibonacci(a - 1) + Fibonacci(a - 2);//Contabiliza los numeros de fibonacci
        }
    }
}
