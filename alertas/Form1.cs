using System;
using System.Windows.Forms;

namespace alertas
{
    public partial class frmAlertas : Form
    {
        public frmAlertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse é um alerta simples", "Com Titulo");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?",
                                                    "Título aqui",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                MessageBox.Show("Respondeu que sim!");
            else
                MessageBox.Show("Respondeu que não.");
        }
    }
}


