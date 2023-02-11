using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtIParcial.Text == "")
            {
                errorProvider1.SetError(txtIParcial, "Ingrese un codigo");
                return;
            }
            if (txtIIParcial.Text == "")
            {
                errorProvider1.SetError(txtIIParcial, "Ingrese un codigo");
                return;
            }
            if (txtIIIParcial.Text == "")
            {
                errorProvider1.SetError(txtIIIParcial, "Ingrese un codigo");
                return;
            }
            if (txtIVParcial.Text == "")
            {
                errorProvider1.SetError(txtIVParcial, "Ingrese un codigo");
                return;
            }
            errorProvider1.Clear();

            decimal nota1 = Convert.ToDecimal(txtIParcial.Text);
            decimal nota2 = Convert.ToDecimal(txtIIParcial.Text);
            decimal nota3 = Convert.ToDecimal(txtIIIParcial.Text);
            decimal nota4 = Convert.ToDecimal(txtIVParcial.Text);

            decimal calcular = await Promedio_FinalAsync(nota1, nota2, nota3, nota4);


            txtPromedioFinal.Text = Convert.ToString(calcular);
        }

        //Funcion
        private async Task<decimal> Promedio_FinalAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal resultado = await Task.Run(() =>
            {
               return (n1 + n2 + n3 + n4) / 4;
                
            });

            return resultado;
         
        }
    }
}
