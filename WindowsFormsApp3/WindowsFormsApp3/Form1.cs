using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Hanoi.Program;

namespace WindowsFormsApp3
{
    public partial class TorresDeHanoi : Form
    {
        static DataTable tabla;
        static Table solution = new Table();
        static int discNum, numMoves = 1;
        bool espacioLibre = true;
        public TorresDeHanoi()
        {
            InitializeComponent();
        }


        private void Siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    discNum = int.Parse(textBox1.Text);
                    if (discNum > 15)
                        throw new ArgumentException();
                    //textBox1.Text = "";
                    //Execute();
                    //AskRows();
                    //numMoves = 1;
                }
                catch (FormatException)
                {
                    MessageBox.Show("iNGRESE POR FAVOR SOLO NUMEROS");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Muchos discos");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in solution.AddList())
            {
                tabla.Rows.Clear();
            }
        }
        public void Executar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Paso");
            tabla.Columns.Add("Disco a mover");
            tabla.Columns.Add("Torre Origen");
            tabla.Columns.Add("Torre Destino");
            dataGridView1.DataSource = tabla;
            Programa.torreHannoi TorreA = new Programa.torreHannoi(discNum);
            Programa.torreHannoi TorreB = new Programa.torreHannoi("B");
            //Programa.torreHannoi TorreC= new Programa.torreHannoi("C");
            //ordenar(discNum, ref TorreA, ref TorreB, ref TorreC);

        }
        static private void SaveTowers(Programa.torreHannoi torrede , Programa.torreHannoi torrelista)
        {
            Row fila = new Row()
            {
                Discs = torrede.getfinal(),
                MoveNum = numMoves++,
                //FromTower = torrede.getNombre(),
                //ToTower = torrelista.getNumeros()

            };
        }
    }
    public class Row
    {
        public int MoveNum { get; set; }
        public object Discs { get; set; }
        public string FromTower { get; set; }
        public string ToTower { get; set; }
    }
    public class Table
    {
        List<Row> table = new List<Row>();
        public void Save(Row fila)
        {
            table.Add(fila);
        }
        public List<Row> AddList()
        {
            return table;
        }
    }
    
        public class Programa
        {
            public class disco
            {
                private Object info;
                private disco siguiente;
                private disco anterior;
                public Object getInfo()
                {
                    return info;
                }
                public void getInfo(Object e)
                {
                    info = e;
                }
                public disco getSiguiente()
                {
                    return siguiente;
                }
                public void getSiguiente(disco a)
                {
                    siguiente = a;
                }
                public disco getAnterior()
                {
                    return anterior;
                }
                public void getAnterior(disco a)
                {
                    anterior = a;
                }
            }
            public class torreHannoi
            {
                private disco comienzo;
                private disco final;
                private int discos;
                private string nombre;
                public torreHannoi(int n)
                {
                    discos = n;
                    nombre = "A";
                    for (int i = 1; i <= discos; i++)
                    {
                        if (final == null)
                        {
                            comienzo = new disco();
                            comienzo.getInfo(i);
                            final = comienzo;
                        }
                        else
                        {
                            disco nuevo = new disco();
                            nuevo.getInfo(i);
                            nuevo.getSiguiente(comienzo);
                            nuevo.getAnterior(nuevo);
                            comienzo = nuevo;
                        }
                    }
                }
                public torreHannoi(string a)
                {
                    discos = 0;
                    nombre = a;
                }
                public void addEnd(disco a)
                {
                    if (discos == 0)
                    {
                        final = a;
                        comienzo = final;
                    }
                    else
                    {
                        a.getAnterior(final);
                        final.getSiguiente(a);
                        final = a;
                    }
                    discos++;
                }
                public disco removeEnd()
                {
                    if (discos == 1)
                    {
                        disco aux = final;
                        final = null;
                        comienzo = null;
                        discos--;
                        return aux;
                    }
                    else
                    {
                        disco aux = final;
                        final = final.getAnterior();
                        final.getSiguiente(null);
                        final.getAnterior(null);
                        discos--;
                        return aux;
                    }
                }
                public Object getNumelements()
                {
                    return final.getInfo();
                }
                public int getNumeros()
                {
                    return discos;
                }
                public Object getsiguientes()
                {
                    return final.getSiguiente();
                }
                public int getfinal()
                {
                    return discos;
                }
                //public int getarrays()
                //{
                //    return ;
                //}

            }
        }

    } 
