using System;
using System.Windows.Forms;

namespace arrayunidimensionalvetor
{
    public partial class FrmVetor : Form
    {
        public FrmVetor()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string[] pecasComputador = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };

            // MessageBox.Show(pecasComputador[2]);

            foreach (string peca in pecasComputador)
                MessageBox.Show(peca);
        }
    }
}
