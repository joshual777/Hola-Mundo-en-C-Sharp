using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Al presionar el boton
        {   
            //Pone visible label 1
            label1.Visible = true; //El label1 se hace visible

            //Pone visible label 2
            label2.Visible = true; //El label 2 se hace visible
            label2.Text = "Hola Mundo 2";  //El label 2 inserta el texto  

            //Caja de Mensaje con Hola Mundo
            MessageBox.Show("Hola Mundo"); //Aparece el cuadro de texto
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
