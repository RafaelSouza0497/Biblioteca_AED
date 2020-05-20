using System;
using Biblioteca;
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
    public partial class Devolucao : Form
    {
        private Livros livrosCarregados;
        private Usuarios usuariosCarregados;
        private DateTime dataAtual;
        private Usuario usuarioSolicitante { get; set; }
        private Livro livroSolicitado { get; set; }

        public Operacao operacao { get; set; }
        public Devolucao()
        {
            InitializeComponent();
        }
        public Devolucao(Livros livrosCarregados, Usuarios usuariosCarregados)
        {
            this.livrosCarregados = livrosCarregados;
            this.usuariosCarregados = usuariosCarregados;
            InitializeComponent();
        }

        public Devolucao(Usuarios usuarios, Livros livros)
        {
            this.usuariosCarregados = usuarios;
            this.livrosCarregados = livros;
            InitializeComponent();
        }


        private void RealizaDevolucao()
        {
            try
            {
               Operacao OpRetirada=(Operacao) usuarioSolicitante.Emprestados.LocalizarOperacao(int.Parse(txb_IdLivro.Text));
                usuarioSolicitante.QuantidadeEmprestimo--;

                if (OpRetirada.DataDevolucao < dataAtual)
                {               
                    TimeSpan tempo = new TimeSpan();
                    tempo = dataAtual - OpRetirada.DataDevolucao;
                    int Dias = Convert.ToInt32(tempo.TotalDays);
                    int DiasSuspensao = Dias * 2;
                    usuarioSolicitante.DataSuspensao = DateTime.Now.Date;
                    usuarioSolicitante.DataSuspensao.AddDays(DiasSuspensao);
                    usuarioSolicitante.Status = false;
                    MessageBox.Show("Entrega em atraso, usuario suspenso por mais "+DiasSuspensao+" dias");
                }
                else MessageBox.Show("Devolucao realizada com sucesso!!");
                LimparDevolucao();
                ListarLivros();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ops esqueceu de carregar algum dado");
            }
        }

        private void LimparDevolucao()
        {
            dgvLivro.Rows.Clear();
            txb_IdLivro.Text = string.Empty;
        }

        private void LimparUsuario()
        {
            dgvUsuario.Rows.Clear();
            txb_IdUser.Text = string.Empty;
        }

        
        private void btnBuscaUsuario_Click_1(object sender, EventArgs e)
        {
            this.usuarioSolicitante = (Usuario)usuariosCarregados.ArvoreUsuarios.Buscar(int.Parse(txb_IdUser.Text));
            dgvUsuario.Rows.Add(usuarioSolicitante.Codigo, usuarioSolicitante.Nome);
            ListarLivros();
        }

        private void ListarLivros()
        {
            Elemento aux = this.usuarioSolicitante.Emprestados.prim.prox;
            if(this.usuarioSolicitante.Emprestados.Vazia()) MessageBox.Show("O usuario nao tem nenhum livro emprestado!!");
            while (aux != null)
            {
                Operacao op = (Operacao)aux.dado;
                Livro livroAtual = op.Livro;
                PreencheGridLivros(livroAtual);
                 aux = aux.prox;
            }

            //this.livroSolicitado = (Livro)livrosCarregados.livros.Buscar(int.Parse(txb_IdLivro.Text));
           
        }
        public void PreencheGridLivros(Livro livroAtual)
        {
            this.livroSolicitado = (Livro)livrosCarregados.livros.Buscar(livroAtual.Codigo);
            dgvLivro.Rows.Add(livroAtual.Codigo, livroSolicitado.Nome);
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                dataAtual = Convert.ToDateTime(mtxbData.Text);
                this.RealizaDevolucao();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Primeiro insira qual o usuario, e qual livro deseja devolver");
            }
        }     
      
        private void dgvLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparDevolucao();
            LimparUsuario();
        }

        private void mtxbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        //// Example #1: Write an array of strings to a file.
        //// Create a string array that consists of three lines.
        //string[] lines = { "First line", "Second line", "Third line" };
        //// WriteAllLines creates a file, writes a collection of strings to the file,
        //// and then closes the file.  You do NOT need to call Flush() or Close().
        //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);


    }
}
