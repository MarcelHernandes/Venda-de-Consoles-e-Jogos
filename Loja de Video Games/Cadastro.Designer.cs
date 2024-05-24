namespace Loja_de_Video_Games
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.ColocarNome = new System.Windows.Forms.TextBox();
            this.ColocarSenha = new System.Windows.Forms.TextBox();
            this.ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.ColocarEmail = new System.Windows.Forms.TextBox();
            this.ConcluirCadastro = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(221, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(320, 34);
            label1.TabIndex = 1;
            label1.Text = "Bem-Vindo ao Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(173, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 34);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(173, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 34);
            label3.TabIndex = 3;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(36, 204);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(236, 34);
            label4.TabIndex = 7;
            label4.Text = "Confirmar Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(169, 262);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 34);
            label5.TabIndex = 8;
            label5.Text = "E-mail:";
            // 
            // ColocarNome
            // 
            this.ColocarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColocarNome.Location = new System.Drawing.Point(279, 104);
            this.ColocarNome.Name = "ColocarNome";
            this.ColocarNome.Size = new System.Drawing.Size(262, 26);
            this.ColocarNome.TabIndex = 4;
            this.ColocarNome.TextChanged += new System.EventHandler(this.ColocarNome_TextChanged);
            // 
            // ColocarSenha
            // 
            this.ColocarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColocarSenha.Location = new System.Drawing.Point(279, 163);
            this.ColocarSenha.Name = "ColocarSenha";
            this.ColocarSenha.Size = new System.Drawing.Size(262, 26);
            this.ColocarSenha.TabIndex = 5;
            this.ColocarSenha.TextChanged += new System.EventHandler(this.ColocarSenha_TextChanged);
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarSenha.Location = new System.Drawing.Point(279, 210);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.Size = new System.Drawing.Size(262, 26);
            this.ConfirmarSenha.TabIndex = 6;
            this.ConfirmarSenha.TextChanged += new System.EventHandler(this.ConfirmarSenha_TextChanged);
            // 
            // ColocarEmail
            // 
            this.ColocarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColocarEmail.Location = new System.Drawing.Point(279, 268);
            this.ColocarEmail.Name = "ColocarEmail";
            this.ColocarEmail.Size = new System.Drawing.Size(262, 26);
            this.ColocarEmail.TabIndex = 9;
            this.ColocarEmail.TextChanged += new System.EventHandler(this.ColocarEmail_TextChanged);
            // 
            // ConcluirCadastro
            // 
            this.ConcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcluirCadastro.Location = new System.Drawing.Point(334, 329);
            this.ConcluirCadastro.Name = "ConcluirCadastro";
            this.ConcluirCadastro.Size = new System.Drawing.Size(158, 55);
            this.ConcluirCadastro.TabIndex = 10;
            this.ConcluirCadastro.Text = "Concluir";
            this.ConcluirCadastro.UseVisualStyleBackColor = true;
            this.ConcluirCadastro.Click += new System.EventHandler(this.ConcluirCadastro_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConcluirCadastro);
            this.Controls.Add(this.ColocarEmail);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.ColocarSenha);
            this.Controls.Add(this.ColocarNome);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColocarNome;
        private System.Windows.Forms.TextBox ColocarSenha;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.TextBox ColocarEmail;
        private System.Windows.Forms.Button ConcluirCadastro;
    }
}