namespace Loja_de_Video_Games
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConsolesAVenda = new System.Windows.Forms.Button();
            this.JogosAVenda = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Carrinho = new System.Windows.Forms.Button();
            this.PrecisandoDeAjuda = new System.Windows.Forms.Button();
            this.Entrar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(194, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(454, 31);
            label1.TabIndex = 0;
            label1.Text = "Bem-Vindo a Loja de Jogos e Consoles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(174, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(490, 31);
            label2.TabIndex = 6;
            label2.Text = "Temos diversos consoles e jogos a venda.";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(28, 318);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(776, 101);
            label3.TabIndex = 7;
            label3.Text = "Compras podem ser feitas presencialmente ou virtualmente e entregaremos em sua ca" +
    "sa o seu console ou jogo que voce queira";
            // 
            // ConsolesAVenda
            // 
            this.ConsolesAVenda.Location = new System.Drawing.Point(12, 12);
            this.ConsolesAVenda.Name = "ConsolesAVenda";
            this.ConsolesAVenda.Size = new System.Drawing.Size(108, 23);
            this.ConsolesAVenda.TabIndex = 1;
            this.ConsolesAVenda.Text = "Consoles a venda";
            this.ConsolesAVenda.UseVisualStyleBackColor = true;
            this.ConsolesAVenda.Click += new System.EventHandler(this.ConsolesAVenda_Click);
            // 
            // JogosAVenda
            // 
            this.JogosAVenda.Location = new System.Drawing.Point(139, 12);
            this.JogosAVenda.Name = "JogosAVenda";
            this.JogosAVenda.Size = new System.Drawing.Size(99, 23);
            this.JogosAVenda.TabIndex = 2;
            this.JogosAVenda.Text = "Jogos a venda";
            this.JogosAVenda.UseVisualStyleBackColor = true;
            this.JogosAVenda.Click += new System.EventHandler(this.JogosAVenda_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(715, 12);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(73, 23);
            this.Cadastrar.TabIndex = 3;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Carrinho
            // 
            this.Carrinho.BackColor = System.Drawing.Color.Transparent;
            this.Carrinho.Location = new System.Drawing.Point(571, 12);
            this.Carrinho.Name = "Carrinho";
            this.Carrinho.Size = new System.Drawing.Size(77, 23);
            this.Carrinho.TabIndex = 4;
            this.Carrinho.Text = "Carrinho";
            this.Carrinho.UseVisualStyleBackColor = true;
            this.Carrinho.Click += new System.EventHandler(this.Carrinho_Click);
            // 
            // PrecisandoDeAjuda
            // 
            this.PrecisandoDeAjuda.BackColor = System.Drawing.Color.Transparent;
            this.PrecisandoDeAjuda.Location = new System.Drawing.Point(327, 12);
            this.PrecisandoDeAjuda.Name = "PrecisandoDeAjuda";
            this.PrecisandoDeAjuda.Size = new System.Drawing.Size(150, 23);
            this.PrecisandoDeAjuda.TabIndex = 5;
            this.PrecisandoDeAjuda.Text = "Precisando de ajuda ?";
            this.PrecisandoDeAjuda.UseVisualStyleBackColor = true;
            this.PrecisandoDeAjuda.Click += new System.EventHandler(this.PrecisandoDeAjuda_Click);
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(654, 12);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(55, 23);
            this.Entrar.TabIndex = 8;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.PrecisandoDeAjuda);
            this.Controls.Add(this.Carrinho);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.JogosAVenda);
            this.Controls.Add(this.ConsolesAVenda);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Loja de Video Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsolesAVenda;
        private System.Windows.Forms.Button JogosAVenda;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Carrinho;
        private System.Windows.Forms.Button PrecisandoDeAjuda;
        private System.Windows.Forms.Button Entrar;
    }
}

