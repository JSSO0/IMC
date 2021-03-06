using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            double peso, altura, imc;

            {
                /*Declaração de variáveis
                variável recebe conteúdo do textbox*/
                /* double peso, altura, imc;*/
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                imc = peso / (altura * altura);
                /* textbox recebe conteúdo da variável imc = resultado do cálculo
                definição de utilização de 2 casas decimais*/
                txtImc.Text = imc.ToString("0.00");
                /*Condições de acordo com os resultados dos cálculos
                Serão exibidas mensagens,
                configuração das messagebox, (mensagens, botões, ícones)
                como são várias condições temos um encadeamento de ifs*/
                if (imc < 18.49)
                    MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (imc < 24.99)
                    MessageBox.Show("SITUAÇÃO: Você está com Peso dentro da Normalidade", "Cálculo deIMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (imc < 29.99)
                    MessageBox.Show("SITUAÇÃO: Você está acima do Peso", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (imc < 34.99)
                    MessageBox.Show("Atenção!Você está com Obesidade Grau I", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if (imc < 39.99)
                    MessageBox.Show("Atenção!Você está com Obesidade Grau II (severa)", "Cálculo deIMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Atenção!Você está com grau de obesidade Grau III (mórbida)",
                   "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

            private void btnLimpar_Click(object sender, EventArgs e)
            {

            }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

