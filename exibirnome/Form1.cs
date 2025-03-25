using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exibirnome
{
    public partial class FrmDesign : Form
    {
        public FrmDesign()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string nome = txtExibirNome.Text;
            MessageBox.Show($"Meu nome é {nome}");
        }

    }
}
