using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class boton : Form
    {
        public boton()
        {
            InitializeComponent();
            Visible2(false);
            //Torredehanoi(3, "izquierda", "mediano", "derecha");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //public void Torredehanoi(int n, string izq, string med, string der)
        //{
        //    //Torredehanoi(n - 1, izq, der, med);
        //    //paso.Text=$"Mover disco {n} de {izq} a {der}";
        //    //Torredehanoi(n - 1, med, izq, der);
        //}
        public void Aux(int cont1)
        {
                switch (cont1)
                {
                    case 1:
                    txt1.Visible = false;
                    txt10.Visible = true;
                    break;
                    case 2:
                        txt1.Visible = false;
                        txt10.Visible = true;
                        break;
                    case 3:
                        txt1.Visible = false;
                        txt20.Visible = true;
                        txt2.Visible = false;
                        break;
                    case 4:

                        txt10.Visible = false;
                        txt1000.Visible = true;
                        break;
                    case 5:
                        txt30.Visible = true;
                        txt3.Visible = false;
                        break;
                    case 6:
                        txt100.Visible = true;
                        txt1000.Visible = false;
                        break;
                    case 7:
                        txt20.Visible = false;
                        txt200.Visible = true;
                        break;
                    case 8:
                        txt100.Visible = false;
                        txt10000.Visible = true;
                        break;
                }
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Visible2(bool a)
        {
            txt1000.Visible = a;
            txt20.Visible = a;
            txt10.Visible = a;
            txt200.Visible = a;
            txt30.Visible = a;
            txt10.Visible = a;
            txt10000.Visible = a;
            txt100.Visible = a;
        }
        private void Txt10(bool a)
        {
            txt10.Visible = a;
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
        public int cont = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            cont++;
            Aux(cont);
        }
    }
}
