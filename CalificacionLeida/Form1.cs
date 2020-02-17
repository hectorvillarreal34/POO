using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionLeida
{
    public partial class ClassGrades : Form
    {
        CalificacionDeClase objCalificaciones = new CalificacionDeClase();

        public ClassGrades()
        {
            InitializeComponent();
        }

        private void ClassGrades_Load(object sender, EventArgs e)
        {

        }

        private void Calificacions_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtgradesPut_TextChanged(object sender, EventArgs e)
        {

        }

        private void Captura_Click(object sender, EventArgs e)
        {
            
            {
            
            objCalificaciones.calicaptura = Convert.ToDecimal(txtcalificacions.Text);
            objCalificaciones.contarAprobacion();
            objCalificaciones.sumarcalificaciones();
            MessageBox.Show("calificacion capturada ");

            }

            txtcalificacions.Clear();
        }

        private void bttRep_Click(object sender, EventArgs e)
        {
            

            txtAprobo.Text = objCalificaciones.aprobados.ToString();
            txtReprobo.Text = objCalificaciones.reprobados.ToString();
            txtPromedio.Text = objCalificaciones.calcularPromedio().ToString();

        }
    }
}