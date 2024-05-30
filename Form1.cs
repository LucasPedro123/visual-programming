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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar uma instância do formulário (OperatorBasic)
            OperatorBasic operatorForm = new OperatorBasic();

            // Exibir o formulário
            operatorForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Criar uma instância do form Media_Mediana
            Media_Mediana operatorForm = new Media_Mediana();

            // Exibir o segundo formulário
            operatorForm.Show();
        }
    }
}
