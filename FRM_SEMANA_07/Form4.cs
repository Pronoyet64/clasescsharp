using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRM_SEMANA_07
{
    public partial class frmOperaciones : Form
    {
        double num01, num02;

        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        // Creando Métodos del Usuario

        private double Sumar(double pN1, double pN2) 
        {
            return pN1 + pN2;
        }

        private double Restar(double pN1, double pN2)
        {
            return pN1 - pN2;
        }

        private double Multiplicar(double pN1, double pN2)
        {
            return pN1 * pN2;
        }

        private double Dividir(double pN1, double pN2)
        {
            return pN1 / pN2;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            //llamamos al metodo tipo void

            LeerDatos();
            if (rbtSumar.Checked)
            {
                resultado = Sumar(num01, num02);
            }

            if (rbtRestar.Checked)
            {
                resultado = Restar(num01, num02);
            }

            if (rbtMultiplicar.Checked)
            {
                resultado = Multiplicar(num01, num02);
            }

            if (rbtDividir.Checked)
            {
                resultado = Dividir(num01, num02);
            }

            lblResultdo.Text = " " + resultado;

        }

        //Metodo tipo Void

        void LeerDatos() 
        {
            num01 = Convert.ToDouble(txtNumero1.Text);
            num02 = Convert.ToDouble(txtNumero2.Text);
        }

    }
}
