using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_matrices
{
    class Ventas
    {
        //ATRIBUTOS
        double[,] matriz;
        int filas;
        int columnas;

        //ENCAPSULACION DE ELEMENTOS
        public double[,] Matriz { get => matriz; set => matriz = value; }
        public int Filas { get => filas; set => filas = value; }
        public int Columnas { get => columnas; set => columnas = value; }

        //METODOS DE LA CLASE

                //Metodo para calcular las ventas totales de los empleados
        public double[] ventasEmpleados()
        {
            double[] empleados = new double[filas];

            for (int i = 0; i < filas; i++)
            {
                double suma = 0;
                for(int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
                empleados[i] = suma;
            }
            return empleados;
        }

                //Metodo para calcular las ventas totales de los meses
        public double[] ventasMeses()
        {
            double[] meses = new double[columnas];
            for(int j = 0; j < columnas; j++)
            {
                double suma = 0;
                for(int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }
                meses[j] = suma;
            }
            return meses;
        }

                 //Metodo para calcular la mayor venta realizada en los meses

        public double mayorMeses()
        {
            double x = -2000;
            double[] mayor = ventasMeses();
            for(int j = 0; j < columnas; j++)
            {
                if (mayor[j] > x)
                {
                    x = mayor[j];
                }

            }
            return x;
        }

                 //Metodo para calcular la mayor venta realizada por los empleados

        public double mayorEmpleados()
        {
            double x = -200;
            double[] mayor = ventasEmpleados();
            for(int i = 0; i < filas; i++)
            {
                if (mayor[i] > x)
                {
                    x = mayor[i];
                }
            }
            return x;
        }


    }
}
