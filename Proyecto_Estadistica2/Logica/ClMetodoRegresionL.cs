using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estadistica2.Logica
{
    internal class ClMetodoRegresionL
    {


        #region Declaracion Variables
        public List<double> XY = new List<double>();
        public List<double> X2 = new List<double>();
        public List<double> Y2 = new List<double>();
        public double sumaX = 0, sumaY = 0, sumaXY = 0, sumaX2 = 0, sumaY2 = 0, potenciaX = 0,
                      potenciaY = 0, A = 0, B = 0, CovX = 0, CovY = 0, CovXY = 0, R = 0;

        #endregion

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

        //metodo para la multiplicacion de X y Y
        public void MetodoXY(List<double> DatoX, List<double> DatoY, int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                XY.Add(DatoX[i] * DatoY[i]);
                sumaXY += XY[i];
            }
        }
        //metodo para elevar al cuadrado las variables X y Y
        public void MetodoCuadrado(List<double> DatoX, List<double> DatoY, int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                X2.Add(Math.Pow(DatoX[i], 2));

                Y2.Add(Math.Pow(DatoY[i], 2));
                sumaX2 += X2[i];
                sumaY2 += Y2[i];
            }
        }
        //metodo para A 
        public void MetodoA(int contador)
        {
            A = ((contador * sumaXY) - (sumaX * sumaY)) / ((contador * sumaX2)-(Math.Pow(sumaX,2)));
        }
        //metodo pata B
        public void MetodoB(int contador)
        {
            B = (sumaY - (A * sumaX)) / (contador);
        }

        //metodo para la covarianza de X
        public void MetodoCovX(double MeidaX, int contador)
        {
            CovX = Math.Sqrt((sumaX2 / contador) - Math.Pow(MeidaX,2));
        }
        //Metodo para la covarianza de Y
        public void MetodoCovY(double MeidaY, int contador)
        {
            CovY = Math.Sqrt((sumaY2 / contador) - Math.Pow(MeidaY, 2));
        }
        //metodo para la covarianza de XY
        public void MetodoCovXY(double MediaX, double MediaY, int contador)
        {
            CovXY = (sumaXY / contador) - ((MediaX * MediaY));
        }
        //metodo para R
        public void MetodoR()
        {
            R = CovXY / (CovX * CovY);
        }
    }
}
