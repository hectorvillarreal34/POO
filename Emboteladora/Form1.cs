using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emboteladora
{
    public partial class Frmemboteladora : Form
    {
        public Frmemboteladora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVarify_Click(object sender, EventArgs e)
        {
            Classbottles objbottles = new Classbottles();

            objbottles.nivelLlenado = Convert.ToInt32(txtnivellenado.Text);
            MessageBox.Show(objbottles.verificarLlenado());

        }
    }
}
