using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            
            try
            {
                float numero;
                if (txtNumero.Text.Contains("$"))
                {
                    numero = float.Parse(txtNumero.Text.Remove(0, 1));
                }else numero = float.Parse(txtNumero.Text);

                float porcentaje = float.Parse(txtPorcentaje.Text);
                float porcentajemod = (porcentaje / 100) + 1;
                float resultadoReal;
                float resultadoComun;
                if (rbSumar.Checked)
                {
                    resultadoReal = numero * porcentajemod;
                    resultadoComun = (numero * porcentaje) / 100 + numero;
                    txtResultadoReal.Text = resultadoReal.ToString();
                    txtResultadoComun.Text = resultadoComun.ToString();
                }
                else if (rbRestar.Checked)
                {
                    resultadoReal = numero / porcentajemod;
                    resultadoComun = numero - ((numero * porcentaje) / 100);
                    txtResultadoReal.Text = resultadoReal.ToString();
                    txtResultadoComun.Text = resultadoComun.ToString();
                }
            }
            catch (Exception ex) { 
            
                
                MessageBox.Show("Error del Programa verifique los datos ingresados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            
        }

        private void FrmPrimcipal_Load(object sender, EventArgs e)
        {
            txtNumero.AppendText("$");
        }
    }
}
