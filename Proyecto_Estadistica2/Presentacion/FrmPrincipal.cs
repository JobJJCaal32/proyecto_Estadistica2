using Proyecto_Estadistica2.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estadistica2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnRegresionLineal_Click(object sender, EventArgs e)
        {
            FrmRegresionL Fp = new FrmRegresionL();
            this.Hide();
            Fp.Show();
        }

        private void BtnMinimosCuadrados_Click(object sender, EventArgs e)
        {
            FrmMinimosC Fp = new FrmMinimosC();
            this.Hide();
            Fp.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }
    }
}
