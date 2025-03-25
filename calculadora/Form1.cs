using System;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        // =====================================
        // 1. ENTRADA DE NÚMEROS
        // =====================================

        private void agregarNumero(object sender, EventArgs e)
        {
            var botao = (Button)sender; // Converte sender para Button

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += botao.Text; // Adiciona o número pressionado ao display
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnSinal_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.StartsWith("-"))
            {
                txtResultado.Text = txtResultado.Text.Substring(1); // Remove o sinal negativo
            }
            else
            {
                txtResultado.Text = "-" + txtResultado.Text; // Adiciona o sinal negativo
            }
        }

        // =====================================
        // 2. SELEÇÃO DE OPERADOR
        // =====================================

        private void clickOperador(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            Numero1 = double.Parse(txtResultado.Text, System.Globalization.CultureInfo.InvariantCulture); //não depende da configuração de idioma do sistema. Usa o ponto '.' como separador decimal, independentemente do idioma do usuário.
            Operador = botao.Text[0]; // Pega o primeiro caractere da string do botão

            if (Operador == '²') // Eleva ao quadrado
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√') // Raiz quadrada
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0"; // Prepara para entrada do segundo número
            }
        }


        // =====================================
        // 3. MANIPULAÇÃO DO DISPLAY
        // =====================================

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0"; // Apenas reseta o número atual
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0"; // Reseta tudo
        }

        // =====================================
        // 4. CÁLCULO FINAL
        // =====================================

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Usa a cultura padrão para evitar erros de formatação com ponto decimal
            Numero2 = double.Parse(txtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
            }
            else if (Operador == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
            }
            else if (Operador == '÷')
            {
                if (Numero2 != 0)
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                }
                else
                {
                    MessageBox.Show("Não pode dividir por zero!");
                }
            }

            // Atualiza Numero1 para cálculos contínuos, garantindo conversão correta
            Numero1 = double.Parse(txtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}

