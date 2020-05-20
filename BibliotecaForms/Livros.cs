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
    public partial class Livros : Form
    {
        public Lista livros { get; }

        public Livros()
        {
            this.livros = new Lista();

            InitializeComponent();
            LeituraLivros();
        }

        private void LeituraLivros()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("livros.txt");
            string linha;

            while ((linha = reader.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                int id = int.Parse(dados[0]);
                string nome = dados[1];
                //int tipo = int.Parse(dados[2]);
                Livro novoLivro = new Livro(id, nome);
                //verifica tipo do livro e adiciona na lista conforme
                //if (tipo == 1)
                //{
                //    novoLivro = new Livro(id, nome);
                //}
                //else if (tipo == 2)
                //{
                //    novoLivro = new LivroVirtual(id, nome);
                //}

                livros.Inserir(novoLivro);

                PreecherGrid(novoLivro.Codigo);
            }
            MessageBox.Show("Livros carregados com sucesso!");
        }

        private void PreecherGrid(int idLivro)
        {
            Livro aux = (Livro)livros.Buscar(idLivro);
            dgvLivros.Rows.Add(aux.Codigo, aux.Nome);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
