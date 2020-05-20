namespace BibliotecaForms
{
    partial class TopLivros
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTopLivros = new System.Windows.Forms.DataGridView();
            this.IdLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emprestimos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(557, 409);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(85, 23);
            this.btn_Voltar.TabIndex = 3;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTopLivros);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 382);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ranking";
            // 
            // dgvTopLivros
            // 
            this.dgvTopLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLivro,
            this.Emprestimos});
            this.dgvTopLivros.Location = new System.Drawing.Point(24, 19);
            this.dgvTopLivros.Name = "dgvTopLivros";
            this.dgvTopLivros.Size = new System.Drawing.Size(570, 345);
            this.dgvTopLivros.TabIndex = 0;
            this.dgvTopLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdLivro
            // 
            this.IdLivro.HeaderText = "IdLivro";
            this.IdLivro.Name = "IdLivro";
            // 
            // Emprestimos
            // 
            this.Emprestimos.HeaderText = "Emprestimos";
            this.Emprestimos.Name = "Emprestimos";
            // 
            // TopLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 444);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "TopLivros";
            this.Text = "TopLivros";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTopLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emprestimos;
    }
}