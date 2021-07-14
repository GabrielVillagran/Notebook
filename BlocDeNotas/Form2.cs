using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class confirma : Form
    {
        public confirma()
        {
            InitializeComponent();
        }
        //Boton de guardar
        private void guardar_Click(object sender, EventArgs e)
        {
            //Creaion ed objeto que llama a los metodos de la form 1
            principal p = new principal();
            //metodo guardar como de form 1
            p.guardarComo();
        }
        //Boton de no guardar
        private void noGuardar_Click(object sender, EventArgs e)
        {
            salir();
        }
        //Boton de cacelar la accion
        private void cancelar_Click(object sender, EventArgs e)
        {
            salir();
        }
        //Metodo para salir de la forma
        private void salir()
        {
            this.Close();
        }

        private void confirma_Load(object sender, EventArgs e)
        {

        }
    }
}
