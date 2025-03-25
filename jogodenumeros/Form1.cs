using System;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class FrmJogoDeNumeros : Form
    {
        int randomNumber;
        int numeroTentativas = 10;
        int palpitedojogador;
        bool jogoGanho = false;
        string dica;

        public FrmJogoDeNumeros()
        {
            InitializeComponent();
        }

        private void FrmJogoDeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            if (jogoGanho)
            {
                txtResultado.Text = "Você já ganhou! Reinicie o jogo para jogar novamente.";
                return;
            }

            if (numeroTentativas == 0)
            {
                txtResultado.Text = "Você não tem mais tentativas. O jogo acabou";
                return;
            }

            if (!int.TryParse(txtNumeroInserido.Text, out palpitedojogador) || palpitedojogador < 1 || palpitedojogador > 100)
            {
                txtResultado.Text = "Por favor, insira um número entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();

            if (palpitedojogador == randomNumber)
            {
                jogoGanho = true;
                dica = "Parabéns, você acertou!";
            }
            else if (palpitedojogador < randomNumber)
                dica = "O número gerado é maior!";
            else
                dica = "O número gerado é menor!";

            txtResultado.Text = dica;
        }
    }
}
