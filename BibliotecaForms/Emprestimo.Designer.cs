namespace BibliotecaForms
{
    partial class Emprestimo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.IdLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscaLivro = new System.Windows.Forms.Button();
            this.txb_IdLivro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.txb_IdUser = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.dgvLivro);
            this.groupBox1.Controls.Add(this.btnBuscaLivro);
            this.groupBox1.Controls.Add(this.txb_IdLivro);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnBuscaUsuario);
            this.groupBox1.Controls.Add(this.txb_IdUser);
            this.groupBox1.Controls.Add(this.dgvUsuario);
            this.groupBox1.Location = new System.Drawing.Point(33, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1258, 420);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Empréstimo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(944, 342);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 35);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Usuario:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(792, 337);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 45);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLivro,
            this.Titulo});
            this.dgvLivro.Location = new System.Drawing.Point(699, 102);
            this.dgvLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(524, 166);
            this.dgvLivro.TabIndex = 12;
            // 
            // IdLivro
            // 
            this.IdLivro.HeaderText = "IdLivro";
            this.IdLivro.Name = "IdLivro";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // btnBuscaLivro
            // 
            this.btnBuscaLivro.Location = new System.Drawing.Point(1150, 43);
            this.btnBuscaLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscaLivro.Name = "btnBuscaLivro";
            this.btnBuscaLivro.Size = new System.Drawing.Size(72, 35);
            this.btnBuscaLivro.TabIndex = 11;
            this.btnBuscaLivro.Text = "Buscar";
            this.btnBuscaLivro.UseVisualStyleBackColor = true;
            this.btnBuscaLivro.Click += new System.EventHandler(this.btnBuscaLivro_Click);
            // 
            // txb_IdLivro
            // 
            this.txb_IdLivro.Location = new System.Drawing.Point(754, 42);
            this.txb_IdLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_IdLivro.Name = "txb_IdLivro";
            this.txb_IdLivro.Size = new System.Drawing.Size(193, 26);
            this.txb_IdLivro.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1095, 342);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 35);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.Location = new System.Drawing.Point(498, 43);
            this.btnBuscaUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(72, 35);
            this.btnBuscaUsuario.TabIndex = 8;
            this.btnBuscaUsuario.Text = "Buscar";
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click);
            // 
            // txb_IdUser
            // 
            this.txb_IdUser.Location = new System.Drawing.Point(141, 46);
            this.txb_IdUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_IdUser.Name = "txb_IdUser";
            this.txb_IdUser.Size = new System.Drawing.Size(193, 26);
            this.txb_IdUser.TabIndex = 6;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.Nome});
            this.dgvUsuario.Location = new System.Drawing.Point(46, 102);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(524, 166);
            this.dgvUsuario.TabIndex = 0;
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "IdUser";
            this.IdUser.Name = "IdUser";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 465);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.TextBox txb_IdUser;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnBuscaLivro;
        private System.Windows.Forms.TextBox txb_IdLivro;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
    }
}