using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtrosControlesEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //Evento agregar boton
            string elem = txtNombre.Text;
            listView1.Items.Add(elem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Para que una vez que se carga el Form, aparezcan los colores cargados
            //en el comboBox 
            comboColor.Items.Add("Rojo");
            comboColor.Items.Add("Verde");
            comboColor.Items.Add("Amarillo");
        }

        private void botonPerfil_Click(object sender, EventArgs e)
        {
            //Obtener valor de un textbox
            string nombre = txtNombre.Text;

            //Obtener valor de un DateTimePicker
            DateTime fecha = dateTimePicker1.Value;

            //Obtener valor del checkbox
            //Operador ternariosi
            string chocolate = checkboxChocolate.Checked == true ? "Si" : "No";

            //Seleccion de combo: Va toString porque devuelve un Object, no un string
            string colorFav = comboColor.SelectedItem.ToString();


            //String numeroFavorito = numFav.Value.toString()

            MessageBox.Show("Nombre: " + nombre + " fecha: " + fecha + "Chocolate: " + chocolate + " color: " + colorFav);
        
        }
    }
}
