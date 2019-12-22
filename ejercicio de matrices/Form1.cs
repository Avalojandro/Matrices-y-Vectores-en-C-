using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_de_matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Creacion de la nueva instancia de la clase
            Ventas ventas = new Ventas();
            ventas.Filas = 4;
            ventas.Columnas = 3;
            ventas.Matriz = new double[ventas.Filas, ventas.Columnas];

            string[] Meses = { "Enero", "Febrero", "Marzo" };
            double[] totalMeses;
            double[] totalEmpleados;
            double mayorMeses;
            double mayorEmpleados;

            //Llenando la matriz
            for(int i = 0; i < ventas.Filas; i++)
            {
                for(int j = 0; j < ventas.Columnas; j++)
                {

                    //validacion de datos
                    while (ventas.Matriz[i, j] < 0)
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Porfavor introducir un valor mayor a cero");
                        ventas.Matriz[i, j] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introducir ventas de " + (i + 1) + " empleado en " + (Meses[j]) + "", "INTRODUCIR DATOS"));
                    }
                    try
                    { 
                    ventas.Matriz[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introducir ventas de "+(i+1)+" empleado en "+(Meses[j])+"", "INTRODUCIR DATOS"));
                    }
                    catch (FormatException)
                    {
                        Microsoft.VisualBasic.Interaction.MsgBox("Porfavor introducir un valor valido");
                        ventas.Matriz[i, j] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introducir ventas de " + (i + 1) + " empleado en " + (Meses[j]) + "", "INTRODUCIR DATOS"));
                    }
                    while (ventas.Matriz[i, j] < 0)
                        {
                            Microsoft.VisualBasic.Interaction.MsgBox("Porfavor introducir un valor mayor a cero");
                            ventas.Matriz[i, j] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introducir ventas de " + (i + 1) + " empleado en " + (Meses[j]) + "", "INTRODUCIR DATOS"));
                        }


                }

                tabla.Rows.Add(ventas.Matriz[i,0], ventas.Matriz[i, 1], ventas.Matriz[i, 2]);

            }

            //Llamado de metodos
            totalMeses = ventas.ventasMeses();
            totalEmpleados = ventas.ventasEmpleados();
            mayorMeses = ventas.mayorMeses();
            mayorEmpleados = ventas.mayorEmpleados();

            //Salida de datos

                //Empleados
            txtempleado1.Text = Convert.ToString(totalEmpleados[0]);
            txtempleado2.Text = Convert.ToString(totalEmpleados[1]);
            txtempleado3.Text = Convert.ToString(totalEmpleados[2]);
            txtempleado4.Text = Convert.ToString(totalEmpleados[3]);

                //Meses
            txtenero.Text = Convert.ToString(totalMeses[0]);
            txtfebrero.Text = Convert.ToString(totalMeses[1]);
            txtmarzo.Text = Convert.ToString(totalMeses[2]);

            //Mayores ventas
            txtmayorempleados.Text = Convert.ToString(mayorEmpleados);
            txtmayormeses.Text = Convert.ToString(mayorMeses);
            
        }

    }
}
