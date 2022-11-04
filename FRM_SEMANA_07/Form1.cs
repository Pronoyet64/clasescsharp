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
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void frmSwitch_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
                cmbMes.Items.Add(i);

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numeroMes = 0;

            if (cmbMes.Text.Length > 0)
            {
                numeroMes = Convert.ToInt32(cmbMes.Text);
                lblResultado.ForeColor = Color.Red;

                switch (numeroMes)
                {
                    case 1:
                        lblResultado.Text = "Enero";
                        break;
                    case 2:
                        lblResultado.Text = "Febrero";
                        break;
                    case 3:
                        lblResultado.Text = "Marzo";
                        break;
                    case 4:
                        lblResultado.Text = "Abril";
                        break;
                    case 5:
                        lblResultado.Text = "Mayo";
                        break;
                    case 6:
                        lblResultado.Text = "Junio";
                        break;
                    case 7:
                        lblResultado.Text = "Julio";
                        lblResultado.ForeColor = Color.Green;
                        break;
                    case 8:
                        lblResultado.Text = "Agosto";
                        lblResultado.ForeColor = Color.Green;
                        break;
                    case 9:
                        lblResultado.Text = "Setiembre";
                        lblResultado.ForeColor = Color.Green;
                        break;
                    case 10:
                        lblResultado.Text = "Octubre";
                        lblResultado.ForeColor = Color.Green;
                        break;
                    case 11:
                        lblResultado.Text = "Noviembre";
                        lblResultado.ForeColor = Color.Green;
                        break;
                    case 12:
                        lblResultado.Text = "Diciembre";
                        lblResultado.ForeColor = Color.Green;
                        break;
                }
            }
            else
            {
                lblResultado.Text = "Seleccione un número de mes";
                lblResultado.ForeColor = Color.Red;
            }

        }
    }
}
