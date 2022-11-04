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
    public partial class frmEstado : Form
    {
        public frmEstado()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double boni = 0;
            string cargo = cmbCargo.Text;
            string estado = cmbEstadoCivil.Text;

            if (cargo.Equals("PROGRAMADOR") || estado.Equals("C")) 
            {
                boni = 500;
            }
            txtR.Text = " " + boni;


        }
    }
}
