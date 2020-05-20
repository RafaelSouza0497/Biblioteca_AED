namespace BibliotecaForms
{
    partial class Biblioteca
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisEmprestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCarregar1 = new System.Windows.Forms.Button();
            this.btnCarregar2 = new System.Windows.Forms.Button();
            this.BtnCarregaOperacoes = new System.Windows.Forms.Button();
            this.realizarDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(636, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeEmpréstimoToolStripMenuItem,
            this.verificarStatusToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.usuárioToolStripMenuItem.Text = "Usuários";
            // 
            // relatórioDeEmpréstimoToolStripMenuItem
            // 
            this.relatórioDeEmpréstimoToolStripMenuItem.Name = "relatórioDeEmpréstimoToolStripMenuItem";
            this.relatórioDeEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.relatórioDeEmpréstimoToolStripMenuItem.Text = "Relatório de Empréstimo";
            this.relatórioDeEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeEmpréstimoToolStripMenuItem_Click);
            // 
            // verificarStatusToolStripMenuItem
            // 
            this.verificarStatusToolStripMenuItem.Name = "verificarStatusToolStripMenuItem";
            this.verificarStatusToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.verificarStatusToolStripMenuItem.Text = "Verificar status";
            this.verificarStatusToolStripMenuItem.Click += new System.EventHandler(this.verificarStatusToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.relatórioDeLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(242, 30);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.ListarToolStripMenuItem1_Click);
            // 
            // relatórioDeLivrosToolStripMenuItem
            // 
            this.relatórioDeLivrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maisEmprestadosToolStripMenuItem,
            this.porDataToolStripMenuItem});
            this.relatórioDeLivrosToolStripMenuItem.Name = "relatórioDeLivrosToolStripMenuItem";
            this.relatórioDeLivrosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.relatórioDeLivrosToolStripMenuItem.Text = "Relatório de Livros";
            // 
            // maisEmprestadosToolStripMenuItem
            // 
            this.maisEmprestadosToolStripMenuItem.Name = "maisEmprestadosToolStripMenuItem";
            this.maisEmprestadosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.maisEmprestadosToolStripMenuItem.Text = "Mais Emprestados";
            this.maisEmprestadosToolStripMenuItem.Click += new System.EventHandler(this.maisEmprestadosToolStripMenuItem_Click);
            // 
            // porDataToolStripMenuItem
            // 
            this.porDataToolStripMenuItem.Name = "porDataToolStripMenuItem";
            this.porDataToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.porDataToolStripMenuItem.Text = "Por Data";
            this.porDataToolStripMenuItem.Click += new System.EventHandler(this.porDataToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarEmpréstimoToolStripMenuItem,
            this.realizarDevoluçãoToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // realizarEmpréstimoToolStripMenuItem
            // 
            this.realizarEmpréstimoToolStripMenuItem.Name = "realizarEmpréstimoToolStripMenuItem";
            this.realizarEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.realizarEmpréstimoToolStripMenuItem.Text = "Realizar Empréstimo";
            this.realizarEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.realizarEmpréstimoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCarregar1
            // 
            this.btnCarregar1.Location = new System.Drawing.Point(78, 108);
            this.btnCarregar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregar1.Name = "btnCarregar1";
            this.btnCarregar1.Size = new System.Drawing.Size(132, 62);
            this.btnCarregar1.TabIndex = 5;
            this.btnCarregar1.Text = "Carregar dados de Usuários";
            this.btnCarregar1.UseVisualStyleBackColor = true;
            this.btnCarregar1.Click += new System.EventHandler(this.btnCarregarDados1_Click);
            // 
            // btnCarregar2
            // 
            this.btnCarregar2.Location = new System.Drawing.Point(252, 108);
            this.btnCarregar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarregar2.Name = "btnCarregar2";
            this.btnCarregar2.Size = new System.Drawing.Size(132, 62);
            this.btnCarregar2.TabIndex = 6;
            this.btnCarregar2.Text = "Carregar dados de Livros";
            this.btnCarregar2.UseVisualStyleBackColor = true;
            this.btnCarregar2.Click += new System.EventHandler(this.BtnCarregar2_Click);
            // 
            // BtnCarregaOperacoes
            // 
            this.BtnCarregaOperacoes.Location = new System.Drawing.Point(428, 108);
            this.BtnCarregaOperacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCarregaOperacoes.Name = "BtnCarregaOperacoes";
            this.BtnCarregaOperacoes.Size = new System.Drawing.Size(132, 62);
            this.BtnCarregaOperacoes.TabIndex = 7;
            this.BtnCarregaOperacoes.Text = "Carregar dados de Operações";
            this.BtnCarregaOperacoes.UseVisualStyleBackColor = true;
            this.BtnCarregaOperacoes.Click += new System.EventHandler(this.button2_Click);
            // 
            // realizarDevoluçãoToolStripMenuItem
            // 
            this.realizarDevoluçãoToolStripMenuItem.Name = "realizarDevoluçãoToolStripMenuItem";
            this.realizarDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.realizarDevoluçãoToolStripMenuItem.Text = "Realizar Devolução";
            this.realizarDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.realizarDevoluçãoToolStripMenuItem_Click);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 278);
            this.Controls.Add(this.BtnCarregaOperacoes);
            this.Controls.Add(this.btnCarregar2);
            this.Controls.Add(this.btnCarregar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Biblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCarregar1;
        private System.Windows.Forms.ToolStripMenuItem verificarStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.Button btnCarregar2;
        private System.Windows.Forms.Button BtnCarregaOperacoes;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maisEmprestadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarDevoluçãoToolStripMenuItem;
    }
}

