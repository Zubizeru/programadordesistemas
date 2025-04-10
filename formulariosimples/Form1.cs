using System;
using System.Text;
using System.Windows.Forms;

namespace formulariosimples
{
    public partial class FrmFormularioSimples : Form
    {
        public FrmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Declaração de váriaveis
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            StringBuilder erros = new StringBuilder(); //classe usada para manipular strings de forma eficiente, pois evita a criação de múltiplas instâncias de string

            //Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text))
                erros.AppendLine("Por favor, preencha o número de cadastro.");
            else if (!int.TryParse(txtNumeroCadastro.Text, out numeroCadastro))
                erros.AppendLine("O número de cadastro deve ser um valor numérico.");
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
                erros.AppendLine("Por favor, preencha o nome completo.");
            if (comboBoxCidade.SelectedItem == null)
                erros.AppendLine("Por favor, selecione uma cidade.");

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
                erros.AppendLine("Por favor, selecione o gênero.");

            //Validação de data
            dataNascimento = dateTimePicker1.Value.Date;
            if (dataNascimento >= DateTime.Now.Date)
                erros.AppendLine("Verifique novamente a sua data de nascimento.");

            // Mais validação (numeroCadastro e dataNascimento já foram declarados lá em cima)
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determinar o gênero selecionado
            string generoSelecionado = "Não Informado";
            if (generoF) generoSelecionado = "Feminino";
            else if (generoM) generoSelecionado = "Masculino";
            else if (generoNB) generoSelecionado = "Não Binário";

            // Exibir as informações em MessageBox
            MessageBox.Show($@"Número Cadastro: {numeroCadastro}
Nome: {nomeUsuario}
Data de Nascimento: {dataFormatada}
Cidade: {cidade}
Gênero: {generoSelecionado}
","Cadastro realizado com sucesso!");

            //Verificar se teve algum erro e mostrar para o usuário
            if (erros.Length > 0)
                MessageBox.Show(erros.ToString());
        }

        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            if (txtNumeroCadastro.Text == "Número Cadastro")
            txtNumeroCadastro.Text = "";
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "Insira seu nome completo")
                txtNomeCompleto.Text = "";
        }
    }
}
