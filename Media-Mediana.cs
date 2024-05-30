using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Media_Mediana : Form
    {
        public Media_Mediana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, mediana;

            // Obter os valores dos controles de texto e convertê-los para double
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);

            // Colocar os valores em um array para facilitar a ordenação
            double[] valores = { n1, n2, n3 };

            // Ordenar os valores
            Array.Sort(valores);

            // Verificar se o número de valores é ímpar ou par
            if (valores.Length % 2 == 1)
            {
                // Se for ímpar, a mediana é o valor central
                mediana = valores[valores.Length / 2];
            }
            else
            {
                // Se for par, a mediana é a média dos dois valores centrais
                int meio = valores.Length / 2;
                mediana = (valores[meio - 1] + valores[meio]) / 2.0;
            }

            // Exibir a mediana
            textBox4.Text = mediana.ToString();

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);

            media = (n1 + n2 + n3) / 3;

            textBox4.Text = media.ToString();
        }
    }
}
