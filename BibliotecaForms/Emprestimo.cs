using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class Emprestimo : Form
    {
        private Livros livrosCarregados;
        private Usuarios usuariosCarregados;

        private Usuario usuarioSolicitante { get; set; }
        private Livro livroSolicitado { get; set; }

        public Operacao operacao { get; set; }

        public Emprestimo()
        {
            InitializeComponent();
        }

        public Emprestimo(Livros livrosCarregados, Usuarios usuariosCarregados)
        {
            this.livrosCarregados = livrosCarregados;
            this.usuariosCarregados = usuariosCarregados;
            InitializeComponent();
        }

        public Emprestimo(Usuarios usuarios, Livros livros)
        {
            this.usuariosCarregados = usuarios;
            this.livrosCarregados = livros;
            InitializeComponent();
        }

        private void RealizaEmprestimo()
        {
            try
            {
                if (usuarioSolicitante.QuantidadeEmprestimo == 5 )
                {
                    MessageBox.Show("O Numero maximo de emprestimos ja foi atingido!!");
                }
                else if(usuarioSolicitante.GetStatusAtualizado() == false)
                {
                    MessageBox.Show("O Usuario esta suspenso !!");
                }
                else
                {
                    this.operacao = new Operacao(usuarioSolicitante, livroSolicitado);
                    MessageBox.Show("Empréstimo realizado com sucesso!!\nQuantidade de Emprestimos atual:"+ usuarioSolicitante.QuantidadeEmprestimo);
                    LimparEmprestimo();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimparEmprestimo()
        {
            dgvLivro.Rows.Clear();
            txb_IdLivro.Text = string.Empty;
        }

        private void LimparUsuario()
        {
            dgvUsuario.Rows.Clear();
            txb_IdUser.Text = string.Empty;
        }

        private void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            this.usuarioSolicitante = (Usuario)usuariosCarregados.ArvoreUsuarios.Buscar(int.Parse(txb_IdUser.Text));
            dgvUsuario.Rows.Add(usuarioSolicitante.Codigo, usuarioSolicitante.Nome);
        }

        private void btnBuscaLivro_Click(object sender, EventArgs e)
        {
            try
            {
                this.livroSolicitado = (Livro)livrosCarregados.livros.Buscar(int.Parse(txb_IdLivro.Text));
                dgvLivro.Rows.Add(livroSolicitado.Codigo, livroSolicitado.Nome);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Carregue os livros primeiro");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.RealizaEmprestimo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparEmprestimo();
            LimparUsuario();
        }
    }
}
