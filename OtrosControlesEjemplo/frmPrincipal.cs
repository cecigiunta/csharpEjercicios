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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        //el boton abrir perfil persona
        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Validar si ya hay una abierta para que no se abran dos iguales
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya hay una abierto");
                    return; //finalizo
                } 
            }



            //Navegacion hacia otra ventana: Hacia Perfil Persona
            //Creo la instancia del objeto y la guardo en la variable
            //Le pido que se muestre
            Form1 ventana = new Form1();

            //Ventana contenedora:
            ventana.MdiParent = this;
            ventana.Show();



            //ventana.ShowDialog(); //Muestra para que no aparezca dos veces



        }

        private void toolStripButtonPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog(); //Muestra para que no aparezca dos veces
        }
    }
}
