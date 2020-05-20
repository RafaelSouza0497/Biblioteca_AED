namespace BibliotecaForms
{
    partial class Devolucao
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
            this.txb_IdLivro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscaUsuario = new System.Windows.Forms.Button();
            this.txb_IdUser = new System.Windows.Forms.TextBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxbData = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxbData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.dgvLivro);
            this.groupBox1.Controls.Add(this.txb_IdLivro);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnBuscaUsuario);
            this.groupBox1.Controls.Add(this.txb_IdUser);
            this.groupBox1.Controls.Add(this.dgvUsuario);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(893, 532);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Devolução";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(565, 456);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 35);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Usuario:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(392, 446);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 45);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLivro,
            this.Titulo});
            this.dgvLivro.Location = new System.Drawing.Point(447, 148);
            this.dgvLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(393, 225);
            this.dgvLivro.TabIndex = 12;
            this.dgvLivro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellContentClick);
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
            // txb_IdLivro
            // 
            this.txb_IdLivro.Location = new System.Drawing.Point(518, 103);
            this.txb_IdLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_IdLivro.Name = "txb_IdLivro";
            this.txb_IdLivro.Size = new System.Drawing.Size(193, 26);
            this.txb_IdLivro.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(722, 456);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(128, 35);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnBuscaUsuario
            // 
            this.btnBuscaUsuario.Location = new System.Drawing.Point(340, 96);
            this.btnBuscaUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscaUsuario.Name = "btnBuscaUsuario";
            this.btnBuscaUsuario.Size = new System.Drawing.Size(72, 35);
            this.btnBuscaUsuario.TabIndex = 8;
            this.btnBuscaUsuario.Text = "Buscar";
            this.btnBuscaUsuario.UseVisualStyleBackColor = true;
            this.btnBuscaUsuario.Click += new System.EventHandler(this.btnBuscaUsuario_Click_1);
            // 
            // txb_IdUser
            // 
            this.txb_IdUser.Location = new System.Drawing.Point(139, 103);
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
            this.dgvUsuario.Location = new System.Drawing.Point(46, 148);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(366, 225);
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
            // mtxbData
            // 
            this.mtxbData.Location = new System.Drawing.Point(387, 42);
            this.mtxbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxbData.Mask = "00/00/0000";
            this.mtxbData.Name = "mtxbData";
            this.mtxbData.Size = new System.Drawing.Size(133, 26);
            this.mtxbData.TabIndex = 19;
            this.mtxbData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxbData_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de Devolução :";
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 588);
            this.Controls.Add(this.groupBox1);
            this.Name = "Devolucao";
            this.Text = "Devolucao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.TextBox txb_IdLivro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscaUsuario;
        private System.Windows.Forms.TextBox txb_IdUser;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.MaskedTextBox mtxbData;
        private System.Windows.Forms.Label label3;
    }
}