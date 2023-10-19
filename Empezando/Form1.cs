using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empezando
{
    public partial class FrmPrimcipal : Form
    {
        public FrmPrimcipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNumero.Text);
            float porcentaje = float.Parse(txtPorcentaje.Text);
            float porcentajemod = (porcentaje / 100) + 1;
            float resultado;
            if (rbSumar.Checked)
            {
                resultado = numero * porcentajemod;
                txtResultado.Text = resultado.ToString();   
            }else if (rbRestar.Checked)
            {
                resultado = numero / porcentajemod;
                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
