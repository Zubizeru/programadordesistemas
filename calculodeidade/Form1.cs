using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodeidade
{
    public partial class FrmCalculoIdade : Form
    {
        public FrmCalculoIdade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anonascimento, anoatual, idade;

            anonascimento = int.Parse(txtAnoNasc.Text);

            // int anoatual2 = DateTime.Now.Year;

            anoatual = int.Parse(txtAnoAtual.Text);

            idade = anoatual - anonascimento;

            DialogResult resposta = MessageBox.Show("Já fez Aniversário?", "Aniversário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                idade--;
            }

            lblIdade.Text = idade.ToString();
        }

    }
}
