using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class FrmPictureBox : Form
    {
        private string imagemLocalizada;

        public FrmPictureBox()
        {
            InitializeComponent();
        }

        private void FrmPictureBox_Load(object sender, EventArgs e)
        {
            pbAlien.Image = Image.FromFile(@"C:\Users\jose.ehmendes\source\programadordesistemas\images\alien.gif");
            pbAlien.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\jose.ehmendes\source\programadordesistemas\images\masp-sp.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexarImagem_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
            // caixa de diálogo para abrir o arquivo
            OpenFileDialog abrirarquivo = new OpenFileDialog();
            abrirarquivo.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png|All files(*.*)|*.*";

                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemLocalizada;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
