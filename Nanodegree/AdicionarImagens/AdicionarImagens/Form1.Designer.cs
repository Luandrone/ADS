
namespace AdicionarImagens
{
    partial class form1
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
            this.imagemListBox = new System.Windows.Forms.ListBox();
            this.favoritosListBox = new System.Windows.Forms.ListBox();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemListBox
            // 
            this.imagemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemListBox.FormattingEnabled = true;
            this.imagemListBox.Location = new System.Drawing.Point(12, 21);
            this.imagemListBox.Name = "imagemListBox";
            this.imagemListBox.Size = new System.Drawing.Size(680, 108);
            this.imagemListBox.TabIndex = 0;
            this.imagemListBox.SelectedIndexChanged += new System.EventHandler(this.imagemListBox_SelectedIndexChanged);
            // 
            // favoritosListBox
            // 
            this.favoritosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritosListBox.FormattingEnabled = true;
            this.favoritosListBox.Location = new System.Drawing.Point(12, 171);
            this.favoritosListBox.Name = "favoritosListBox";
            this.favoritosListBox.Size = new System.Drawing.Size(680, 108);
            this.favoritosListBox.TabIndex = 1;
            this.favoritosListBox.SelectedIndexChanged += new System.EventHandler(this.favoritosListBox_SelectedIndexChanged);
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(13, 136);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(170, 23);
            this.AdicionarButton.TabIndex = 2;
            this.AdicionarButton.Text = "Adicionar aos favoritos";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 308);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(206, 135);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(170, 23);
            this.removerButton.TabIndex = 4;
            this.removerButton.Text = "Remover dos favoritos";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 619);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdicionarButton);
            this.Controls.Add(this.favoritosListBox);
            this.Controls.Add(this.imagemListBox);
            this.Name = "form1";
            this.Text = "Visualizador de imagens";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagemListBox;
        private System.Windows.Forms.ListBox favoritosListBox;
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removerButton;
    }
}

