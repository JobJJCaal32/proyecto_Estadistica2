using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estadistica2.Datos
{
    internal class ClMetodoMinimosC
    {
        public List<double> XY = new List<double>();
        public List<double> X2 = new List<double>();
        public List<double> Columna3 = new List<double>();
        public List<double> SCT = new List<double>();
        public List<double> SCRE = new List<double>();
        //la variable SumaSCRE hace referencia a los datos de SCR o SCE
        public double sumaX=0, sumaY=0, sumaXY = 0, sumaX2 = 0, B1 = 0, 
                      B0 = 0, SumaSCT = 0, SumaSCRE = 0, Determinacion = 0, Correlacion = 0;

        //metodos para las medias
        public double Media(List<double> Dato, int contador)
        {
            double _Media = 0;
            for (int i = 0; i < contador; i++)
            {
                _Media += Dato[i];
            }
            return _Media = _Media / contador;
        }

        //metodo sumas de X y Y
        public void Sumas(List<double> DatoX, List<double> DatoY, int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                sumaX += DatoX[i];
                sumaY += DatoY[i];
            }
        }
        //metodo para la multiplicacion de x y y (X-MediaX) * (Y-MediaY)
        public void MetodoXY(List<double> DatoX, double MediaX, List<double> DatoY, double MediaY, int contador)
        {
            for(int i=0; i <contador; i++) {
                XY.Add((DatoX[i] - MediaX) * (DatoY[i] - MediaY));
                sumaXY += XY[i];
            }
        }
        // metodo para la X al cuadrado (X-MediaX)^2
        public void MetodoX2(List<double> DatoX, double MediaX,int contador)
        {
            for(int i = 0; i < contador; i++ ) {
                X2.Add(Math.Pow((DatoX[i] - MediaX), 2));
                sumaX2 += X2[i];    
            } 
        }
        //metodo para el calculo de B1
        public void MetodoB1()
        {
            B1 = sumaXY / sumaX2;
        }
        //metodo para el calculo de B0
        public void MetodoB0(double MediaX, double MediaY)
        {
            B0 = MediaY - (MediaX * B1);
        }
        //metodo para el calculo de pronostico de regresion 
        public void MetodoPronostico(List<double> DatoX, int contador)
        {
            for (int i=0;i < contador;i++)
            {
                Columna3.Add(B0 + (B1 * DatoX[i]));
            }
        }

        public void MetodoSCT(List<double> DatoY,double MediaY, int contador)
        {
            for (int i = 0; i < contador; i++) {
                SCT.Add(Math.Pow((DatoY[i] - MediaY),2));
                SumaSCT += SCT[i];
            }
        }
        //metodo para el calculo de SCR
        public void MetodoSCR(double MediaY, int Contador)
        {
            for(int i=0; i<Contador;i++) {
                SCRE.Add(Math.Pow((Columna3[i] - MediaY),2));
                SumaSCRE += SCRE[i];
            }
        }
        //metodo para el calculo de SCE
        public void MetodoSCE(List<double> DatoY, int contador)
        {
            for(int i=0; i < contador;i++) 
            {
                SCRE.Add(Math.Pow((DatoY[i] - Columna3[i]), 2));
                SumaSCRE += SCRE[i];

            }
        }
        //metodo para R^2 coeficiente de determinacion 
        public void MetodoDeterminacion(double Dato)
        {
            Determinacion = Dato / SumaSCT;
        }
        //metod para R coeficiente de correlacion
        public void MetodoCorrelacion(double Dato)
        {
            Correlacion = Math.Sqrt(Dato);
        }
    }
}
