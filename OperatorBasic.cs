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
    public partial class OperatorBasic : Form
    {
        public OperatorBasic()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double v1, v2, divider;//declaro variável
            v1 = Double.Parse(textBox1.Text);
            v2 = Double.Parse(textBox2.Text);

            divider = v1 / v2; //subtraindo os valores

            textBox3.Text = divider.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double v1, v2, soma;//declaro variável
            v1 = Double.Parse(textBox1.Text);
            v2 = Double.Parse(textBox2.Text);

            soma = v1 + v2;//somando os valores

            textBox3.Text = soma.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Double v1, v2, subtract;//declaro variável
            v1 = Double.Parse(textBox1.Text);
            v2 = Double.Parse(textBox2.Text);

            subtract = v1 - v2; //subtraindo os valores

            textBox3.Text = subtract.ToString();
        }

        private void btnMultiplic_Click(object sender, EventArgs e)
        {
            Double v1, v2, multiplic;//declaro variável
            v1 = Double.Parse(textBox1.Text);
            v2 = Double.Parse(textBox2.Text);

            multiplic = v1 * v2; //subtraindo os valores

            textBox3.Text = multiplic.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //limpando caixas de textos
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            //Focar o ponto de Inserção no primeiro textbox(txtValor1)
            textBox1.Focus();
        }
    }
}
