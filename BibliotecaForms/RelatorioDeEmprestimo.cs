using System;
using Biblioteca;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class RelatorioDeEmprestimo : Form
    {
        public ABB ArvoreUsuarios;
        public RelatorioDeEmprestimo(ABB ArvoreUsuarios)
        {
            this.ArvoreUsuarios = ArvoreUsuarios;
            InitializeComponent();
        }

        private void ImprimirEmprestimos(int id)
        {
            try
            {
                Usuario atual = (Usuario)ArvoreUsuarios.Buscar(id);
                Lista Emprestimo = atual.Emprestimos;
                Elemento aux = Emprestimo.prim.prox;

                while (aux != null)
                {
                    Operacao op = (Operacao)aux.dado;

                    PreencheGrid(op);

                    aux = aux.prox;
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario nao exite!!");
            }
        }

        private void PreencheGrid(Operacao nova)
        {
            dataGridView1.Rows.Add(nova.Usuario.Codigo, nova.Livro.Codigo, nova.Data);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_Nome.Text);
            ImprimirEmprestimos(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
