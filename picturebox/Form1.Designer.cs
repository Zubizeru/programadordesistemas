
namespace picturebox
{
    partial class FrmPictureBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPictureBox));
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbImagemImportada = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAlien
            // 
            this.pbAlien.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbAlien.InitialImage")));
            this.pbAlien.Location = new System.Drawing.Point(12, 153);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(266, 350);
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;
            // 
            // pbComputador
            // 
            this.pbComputador.Image = global::picturebox.Properties.Resources.computador1;
            this.pbComputador.Location = new System.Drawing.Point(12, 5);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(391, 133);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 1;
            this.pbComputador.TabStop = false;
            // 
            // pbImagemImportada
            // 
            this.pbImagemImportada.Image = global::picturebox.Properties.Resources.computador1;
            this.pbImagemImportada.Location = new System.Drawing.Point(414, 5);
            this.pbImagemImportada.Name = "pbImagemImportada";
            this.pbImagemImportada.Size = new System.Drawing.Size(346, 133);
            this.pbImagemImportada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemImportada.TabIndex = 2;
            this.pbImagemImportada.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(414, 144);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(347, 166);
            this.pbCidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCidade.TabIndex = 3;
            this.pbCidade.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.Gold;
            this.btnVerImagem.Location = new System.Drawing.Point(314, 144);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(89, 63);
            this.btnVerImagem.TabIndex = 4;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.Location = new System.Drawing.Point(115, 7);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(335, 171);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAnexarImagem.TabIndex = 5;
            this.pbAnexarImagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnAnexarImagem);
            this.panel1.Controls.Add(this.pbAnexarImagem);
            this.panel1.Location = new System.Drawing.Point(299, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 188);
            this.panel1.TabIndex = 6;
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.BackColor = System.Drawing.Color.Gold;
            this.btnAnexarImagem.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexarImagem.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnexarImagem.Location = new System.Drawing.Point(15, 7);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(89, 63);
            this.btnAnexarImagem.TabIndex = 6;
            this.btnAnexarImagem.Text = "Anexar Imagem";
            this.btnAnexarImagem.UseVisualStyleBackColor = false;
            this.btnAnexarImagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAnexarImagem_MouseClick);
            // 
            // FrmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(769, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbImagemImportada);
            this.Controls.Add(this.pbComputador);
            this.Controls.Add(this.pbAlien);
            this.Name = "FrmPictureBox";
            this.Text = "Picture Box";
            this.Load += new System.EventHandler(this.FrmPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbImagemImportada;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnexarImagem;
    }
}

