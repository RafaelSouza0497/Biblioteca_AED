using Biblioteca;
using System;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class Biblioteca : Form
    {
        private Usuarios usuarios;
        private Livros livros;
        public CarregaOperacao HashOperacoes;

        public Biblioteca()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                HashOperacoes = new CarregaOperacao(usuarios.ArvoreUsuarios);
                MessageBox.Show("Operacoes carregadas");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Favor carregar os dados de usuário primeiro");
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Favor carregar os dados de usuário primeiro");
            }
        }

        private void btnCarregarDados1_Click(object sender, EventArgs e)
        {
            usuarios = new Usuarios();
        }

        private void BtnCarregar2_Click(object sender, EventArgs e)
        {
            livros = new Livros();
        }

        private void ListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                livros.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Favor carregar os dados de livros primeiro");
            }
        }

        private void relatórioDeEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioDeEmprestimo relatorio = new RelatorioDeEmprestimo(usuarios.ArvoreUsuarios);
                relatorio.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Primeiro carregue os usuarios e as operacoes !");
            }
        }

        private void maisEmprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TopLivros top = new TopLivros(HashOperacoes.GetLivros());
                top.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Carregue os dados dos livros primeiro !");
            }
        }

        private void porDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                EmprestimoData ed = new EmprestimoData(HashOperacoes.GetEmprestimos());
                ed.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Carregue os dados dos livros primeiro !");
            }
        }

        private void verificarStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarStatus status = new VerificarStatus(usuarios.ArvoreUsuarios);
                status.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Favor carregar os dados dos usuarios primeiro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(usuarios, livros);

            emprestimo.ShowDialog();
        }

        private void realizarDevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao devolver = new Devolucao(usuarios, livros);
            devolver.ShowDialog();
        }
    }
}
