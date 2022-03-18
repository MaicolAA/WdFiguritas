using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// <summary>
/// Fecha: 18/03/2022
/// Autores: Oscar David Ramos Calzada, Maicol Arroyave Alvarez
/// Descripción: Grafiacador de figuras 
/// </summary>
namespace WdFiguritas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado square = new Cuadrado();
            square.Show();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo circle = new Circulo();
            circle.Show();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo rectangle = new Rectangulo();
            rectangle.Show();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangle = new Triangulo();
            triangle.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
