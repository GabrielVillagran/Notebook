using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class principal : Form
    {
        string nameArch = null;
        public principal()
        {
            InitializeComponent();
        }
        //Boton de nuevo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirma ventana = new confirma();
            if (nameArch != null)
            {
                textBox.Clear();
           }
            else
            {
              ventana.ShowDialog();
              textBox.Clear();
            }
        }
        //Boton de abrir
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirma ventana = new confirma();
            if (nameArch != null)
            {
                abrir();
            }
            else
            {
                ventana.ShowDialog();
                abrir();
            }
        }
        //Boton de guardar como
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();

        }
        //Boton de salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            confirma ventana = new confirma();
            if (nameArch != null)
            {
                Application.Exit();
            }
            else
            {
                ventana.ShowDialog();
                Application.Exit();
            }
        }
        //Boton de guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarNormal();
        }
        //Metodo para cortar la palabra que se seleccionara
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }
        //Metodo para copiar la palabra que se seleccionara
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }
        //Metodo para pegar lo que se selecciono
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }
        //Metodo para guardar como
        public void guardarComo()
        {
            //la variable archivo guarda el contenido del text box
            string archivo = textBox.Text;
            // msg = mensaje
            SaveFileDialog msg = new SaveFileDialog();
            //Permite que se guarden con la extension .txt
            msg.Filter = "Archivos de texto|*.txt";
            DialogResult res = msg.ShowDialog();
           //Excepcion que me permite guardar el archivo o cancelarlo
            if (res == DialogResult.OK)
                File.WriteAllText(msg.FileName, archivo);
                 nameArch = msg.FileName; // Se obtiene el nombre del archivo para ser usado
        }
        //Metodo para guardar Normal
        private void guardarNormal()
        {
            Console.WriteLine("Se encontro");
            // si el archivo aun no se guarda se procede a guardar como
            if (nameArch != null)
            {
                //Se guardan el texto
                string archivo = textBox.Text;
                File.WriteAllText(nameArch, archivo);
            }
            else
            {
                guardarComo();
           }
        }
        //abre la pantalla de busqueda
        public void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar b = new Buscar();
            b.Info(this); //envia los datos del formulario
            b.ShowDialog();
            b.search();
        }
        //metodo creado para poder abrir los archivos guardados
        private void abrir()
        {
            OpenFileDialog msg = new OpenFileDialog();
            msg.Filter = "Archivos de texto|*.txt";
            DialogResult res = msg.ShowDialog();
            //Excepcion que me permite abrir el archivo o cancelarlo
            if (res == DialogResult.OK)
                textBox.Text = File.ReadAllText(msg.FileName);
        }
    }
}
