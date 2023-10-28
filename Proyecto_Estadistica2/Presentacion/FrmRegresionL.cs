using Proyecto_Estadistica2.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Estadistica2.Presentacion
{
    public partial class FrmRegresionL : Form
    {
        //variables de tipo lista para manipular los datos
        public List<double> DatoX = new List<double>();
        public List<double> DatoY = new List<double>();
        //instancia a la clase de la logica de Regresion Lineal
        ClMetodoRegresionL Datos = new ClMetodoRegresionL();

        public FrmRegresionL()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal Fp = new FrmPrincipal();
            this.Dispose();
            Fp.Show();
        }

        private void BtnIDato_Click(object sender, EventArgs e)
        {
            double x, y;

            if (TxtDatoX.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoX.Focus();
                TxtDatoX.Clear();
            }
            else if (TxtDatoY.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoY.Focus();
                TxtDatoY.Clear();
            }
            else
            {
                x = Convert.ToDouble(TxtDatoX.Text);
                y = Convert.ToDouble(TxtDatoY.Text);
                //se agregan los datos a los listbox
                LbDatosX.Items.Add(x);
                LbDatosY.Items.Add(y);
                //se agregar los datos 
                DatoX.Add(x);
                DatoY.Add(y);
                //se limpian los textbox de ingreso de datos
                TxtDatoX.Clear();
                TxtDatoY.Clear();
                TxtDatoX.Focus();

            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            #region Declaracion Variables
            int contador = DatoX.Count;
            double MediaX, MediaY;
            #endregion
            //se llaman a todos los metodos
            #region Llamado a los metodos
            MediaX = Datos.Media(DatoX, contador);
            MediaY = Datos.Media(DatoY, contador);
            //se mandan los dotos al metodo para que multiplique X y Y
            Datos.Sumas(DatoX, DatoY, contador);
            Datos.MetodoXY(DatoX, DatoY, contador);
            Datos.MetodoCuadrado(DatoX, DatoY, contador);
            Datos.MetodoA(contador);
            Datos.MetodoB(contador);
            Datos.MetodoCovX(MediaX, contador);
            Datos.MetodoCovY(MediaY, contador);
            Datos.MetodoCovXY(MediaX, MediaY, contador);
            Datos.MetodoR();
            #endregion
            //si imprimen todos los datos en los textbox y listbox
            #region Impresion Datos
            TxtMediaX.Text = Convert.ToString(MediaX);
            TxtMediaY.Text = Convert.ToString(MediaY);
            //se imprimen las sumas en los Txtbox
            TxtSumaXY.Text = Convert.ToString(Math.Round(Datos.sumaXY, 3));
            TxtSuma1.Text = Convert.ToString(Math.Round(Datos.sumaX2, 3));
            TxtSuma2.Text = Convert.ToString(Math.Round(Datos.sumaY2, 3));
            TxtA.Text = Convert.ToString(Math.Round(Datos.A, 3));
            TxtB.Text = Convert.ToString(Math.Round(Datos.B, 3));
            TxtCovX.Text = Convert.ToString(Math.Round(Datos.CovX, 3));
            TxtCovY.Text = Convert.ToString(Math.Round(Datos.CovY, 3));
            TxtCovXY.Text = Convert.ToString(Math.Round(Datos.CovXY, 3));
            TxtR.Text = Convert.ToString(Math.Round(Datos.R, 3));

            //se imprimen los datos en los listbox
            for (int i = 0; i < contador; i++)
            {
                LbColumna1.Items.Add(DatoX[i] + " * " + DatoY[i] + " = " + Datos.XY[i]);
                LbColumna2.Items.Add(DatoX[i] + " ^2" + " = " + Datos.X2[i]);
                LbColumna3.Items.Add(DatoY[i] + " ^2" + " = " + Datos.Y2[i]);
            }
            #endregion

            #region diagrama de dispersion
            // Borrar series anteriores, si las hay
            CGrafica.Series.Clear();

            // Crear una nueva serie para los puntos
            Series seriePuntos = new Series("Puntos");
            seriePuntos.ChartType = SeriesChartType.Point;

            // Agregar los puntos desde las listas DatoX y DatoY
            for (int i = 0; i < DatoX.Count; i++)
            {
                seriePuntos.Points.AddXY(DatoX[i], DatoY[i]);
            }

            // Agregar la serie al gráfico CGrafica
            CGrafica.Series.Add(seriePuntos);
            #endregion
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LbDatosX.Items.Clear();
            LbDatosY.Items.Clear();
            LbColumna1.Items.Clear();
            LbColumna2.Items.Clear();
            LbColumna3.Items.Clear();

            TxtMediaX.Clear();
            TxtMediaY.Clear();
            TxtSumaXY.Clear();
            TxtSuma1.Clear();
            TxtSuma2.Clear();

            TxtA.Clear();
            TxtB.Clear();
            TxtCovX.Clear();
            TxtCovY.Clear();
            TxtCovXY.Clear();
            TxtR.Clear();

            DatoX.Clear();
            DatoY.Clear();

            CGrafica.Series.Clear();

            TxtDatoX.Focus();
        }

        private void DatosFormulas_Enter(object sender, EventArgs e)
        {

        }
    }
}
