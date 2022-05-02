using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaioresValoresentreTres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(numericUd1.Value);
            int valor2 = Convert.ToInt32(numericUd2.Value);
            int valor3 = Convert.ToInt32(numericUd3.Value);

            if(valor1 == valor2 || valor2 == valor3)
            {
                lblResultado.Text = "Os valores são iguais";
               
            }

            if (valor1 > valor2 && valor1 > valor3)
            {
                lblResultado.Text = "O valor 1 é o maior entre os demais";
            }
            if (valor2 > valor1 && valor2 > valor3)
            {
                lblResultado.Text = "O valor 2 é o maior entre os demais";
            } if (valor3 > valor1 && valor3 > valor2)

            {
                lblResultado.Text = "O valor 3 é o maior entre os demais";
            }
        }
    }
}
