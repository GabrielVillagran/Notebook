using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Buscar : Form
    {
        int i, datos;
        principal p = new principal();
        public Buscar()
        {
            InitializeComponent();
        }
        //Buscar cadena dentro del texto
        public void busqueda_Click(object sender, EventArgs e)        
        {
            search();
        }
        //cancelar la accion de busqueda
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo para buscar la palabra
        public void search()
        {
            int tamPalabra = p.textBox.Text.Length - searchStr.Text.Length;
            //Si se recorre todo el arreglo se deja de utilizar el metodo
            if (i >= p.textBox.Text.Length) 
            return;
                //Si se recorre todo el vector se deja de realizar el metodo
                while (datos == -1 && i <= tamPalabra)
                {
                    datos = p.textBox.Text.IndexOf(searchStr.Text, i, searchStr.Text.Length);
                    i++;
                }
                if (datos != -1)
                {
                    respuesta.Text = "La palabra se encuentra en el texto";
                    p.textBox.Select(datos, searchStr.Text.Length); //Subraya la palabra
                    i = datos + searchStr.Text.Length + 1;
                    datos = -1;
                }
                else
                {
                    respuesta.Text = "La palabra no se encuentra en el texto";
                }
        }
        //metodo que me permite hacer que el texto se 
        public void Info(principal texto)
        {
            this.p = texto;
        }
    }
}
