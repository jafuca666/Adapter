using Adapter.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Estudiante a in Datos.getArregloEstudiante()) ;
                //if(a.Nombre==textBox1.Text)
                  //  a
                  }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Datos.getArregloEstudiante.);


        }


    }
}
