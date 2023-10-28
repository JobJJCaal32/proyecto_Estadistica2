using Proyecto_Estadistica2.Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Estadistica2.Presentacion
{
    public partial class FrmMinimosC : Form
    {
        //variables de tipo lista para manipular los datos
        public List<double> DatoX = new List<double>();
        public List<double> DatoY = new List<double>();
        double MediaX = 0, MediaY = 0;
        //instancia a la clase de la logica de Minimos Cuadrados
        ClMetodoMinimosC Datos = new ClMetodoMinimosC();
        public FrmMinimosC()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal Fp = new FrmPrincipal();
            this.Dispose();
            Fp.Show();
        }

        private void BtnIDatos_Click(object sender, EventArgs e)
        {
            double x, y, control;
            bool controlX, controlY;

            controlX = Double.TryParse(TxtDatoX.Text, out x);
            controlY = Double.TryParse(TxtDatoY.Text, out y);
            if (TxtDatoX.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoX.Focus();
                TxtDatoX.Clear();
            }
            else if (controlX == false)
            {
                MessageBox.Show("Por favor ingrese datos numericos para X");
                TxtDatoX.Focus();
                TxtDatoX.Clear();
                return;
               
            }
            else if (TxtDatoY.Text == "")
            {
                MessageBox.Show("Por favor ingrese los dos dato para que no haya errores");
                TxtDatoY.Focus();
                TxtDatoY.Clear();
            }
            else if (controlY==false){
                MessageBox.Show("Por favor ingrese datos numericos para Y");
                TxtDatoY.Focus();
                TxtDatoY.Clear();
                return;
            }
            else
            {
                x = Convert.ToDouble(TxtDatoX.Text);
                y = Convert.ToDouble(TxtDatoY.Text);
                //se agregan los datos a los listbox
                LbDatosX.Items.Add(x);
                LbDatosY.Items.Add(y);
                //se agregar los datos a cada arreglo
                DatoX.Add(x);
                DatoY.Add(y);
                //se limpian los textbox de ingreso de datos
                TxtDatoX.Clear();
                TxtDatoY.Clear();
                TxtDatoX.Focus();

            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ImpresionDatos();
            int contador = DatoX.Count;
            double SCR, determinacion;
            Datos.MetodoSCR(MediaY, contador);
            TxtSumaC5.Text = Math.Round(Datos.SumaSCRE, 3).ToString();

            SCR = Datos.SumaSCRE;
            Datos.MetodoDeterminacion(SCR);
            determinacion = Datos.Determinacion;


            Datos.MetodoCorrelacion(determinacion);

            TxtR2.Text = Math.Round(determinacion, 3).ToString();
            TxtR.Text = Math.Round(Datos.Correlacion,3).ToString();
            for (int i = 0; i < contador; i++)
            {
                LbColumna5.Items.Add("(" + Datos.Columna3[i] + " - " + MediaY + ")^2 = " + Datos.SCRE[i]);
            }
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ImpresionDatos();
            int contador = DatoX.Count;
            double SCE, determinacion;
            Datos.MetodoSCE(DatoY, contador);
            TxtSumaC5.Text = Math.Round(Datos.SumaSCRE,3).ToString();

            SCE = Datos.SumaSCRE;
            Datos.MetodoDeterminacion(SCE);
            determinacion = 1-Datos.Determinacion;

            Datos.MetodoCorrelacion(determinacion);

            TxtR2.Text = Math.Round(determinacion, 3).ToString();
            TxtR.Text = Math.Round(Datos.Correlacion, 3).ToString();
            for (int i = 0; i < contador; i++)
            {
                LbColumna5.Items.Add("(" + DatoY[i] + " - " + Datos.Columna3[i] + ")^2 = " + Datos.SCRE[i]);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LbDatosX.Items.Clear();
            LbDatosY.Items.Clear();
            LbColumna1.Items.Clear();
            LbColumna2.Items.Clear();
            LbColumna3.Items.Clear();
            LbColumna4.Items.Clear();
            LbColumna5.Items.Clear();

            TxtMediaX.Clear();
            TxtMediaY.Clear();

            TxtSumaC1.Clear();
            TxtSumaC2.Clear();
            TxtSumaC4.Clear();
            TxtSumaC5.Clear();

            TxtB1.Clear();
            TxtBo.Clear();
            TxtR2.Clear();
            TxtR.Clear();

            DatoX.Clear();
            DatoY.Clear();

            CGrafica.Series.Clear();

            TxtDatoX.Focus();
        }

        public void ImpresionDatos()
        {
            #region Declaracion de variables 
            int contador = DatoX.Count;
            #endregion
            //se hace llamado a todos los metodos
            #region Metodos
            MediaX = Datos.Media(DatoX, contador);
            MediaY = Datos.Media(DatoY, contador);
            Datos.MetodoXY(DatoX, MediaX, DatoY, MediaY, contador);
            Datos.MetodoX2(DatoX, MediaX, contador);
            Datos.MetodoB1();
            Datos.MetodoB0(MediaX,MediaY);
            Datos.MetodoPronostico(DatoX,contador);
            Datos.MetodoSCT(DatoY, MediaY, contador);
            #endregion
            //se imprimen todos los datos 
            #region imprecion
            TxtMediaX.Text = MediaX.ToString(); 
            TxtMediaY.Text = MediaY.ToString();
            TxtSumaC1.Text = Math.Round(Datos.sumaXY,3).ToString();
            TxtSumaC2.Text = Math.Round(Datos.sumaX2,3).ToString();
            TxtB1.Text = Math.Round(Datos.B1,3).ToString();
            TxtBo.Text = Math.Round(Datos.B0,3).ToString();
            TxtSumaC4.Text = Math.Round(Datos.SumaSCT,3).ToString();
            for (int i = 0; i < contador; i++)
            {
                LbColumna1.Items.Add("(" + DatoX[i] + " - " + MediaX + ")*" + "(" + DatoY[i] + " - "
                                    + MediaY + ") = " + Datos.XY[i]);          
                LbColumna2.Items.Add("(" + DatoX[i] + " - " + MediaX + ") ^2 = " + Datos.X2[i]);
                LbColumna3.Items.Add(Datos.B0 + " + " + Datos.B1 + " * " + DatoX[i] + " = " + Datos.Columna3[i]);
                LbColumna4.Items.Add("(" + DatoY[i] + " - " + MediaY + " )^2 = " + Datos.SCT[i]);
            }
            #endregion

            #region Grafica
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
    }
}
