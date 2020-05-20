using System;

namespace Biblioteca
{
    public class Operacao : IDado
    {
        public int Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public int Tipo { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataDevolucao { get; set; }

        private static int contEmprestimo = 5;

        public Operacao(int idUsuario, int idLivro, int Operacao, DateTime data)
        {
            this.Usuario = new Usuario();
            Usuario.Codigo = idUsuario;

            this.Livro = new Livro();
            Livro.Codigo = idLivro;

            this.Tipo = Operacao;
            this.Data = data;
        }

        public Operacao(Usuario usuario, Livro livro, int Operacao, DateTime data)
        {
            this.Usuario = usuario;
            this.Livro = livro;
            this.Tipo = Operacao;
            this.Data = data;
        }

        public Operacao(Usuario usuario, Livro livro)
        {
            this.Usuario = usuario;
            this.Livro = livro;
            this.Tipo = 1;
            this.Data = DateTime.Now.Date;
            this.DataDevolucao = Data.AddDays(7);
            this.Emprestar();
        }

        public Operacao()
        {

        }

        public override string ToString()
        {
            return "Usuario: " + this.Usuario.Codigo + "Livro: " + this.Livro.Codigo;
        }

        public bool Equals(IDado other)
        {
            Operacao aux = (Operacao)(other);
            return (this.Usuario.Codigo == aux.Usuario.Codigo && this.Livro.Codigo == aux.Livro.Codigo);
        }

        private bool PegarEmprestado()
        {
            if (Livro is LivroVirtual) return (DateTime.Now.Date < Usuario.DataSuspensao);

            return (this.Usuario.QuantidadeEmprestimo < contEmprestimo || DateTime.Now.Date < Usuario.DataSuspensao);
        }

        private void Emprestar()
        {
            if (PegarEmprestado())
            {
                Usuario.QuantidadeEmprestimo++;
                Usuario.Emprestimos.Inserir(this);
                Usuario.Emprestados.Inserir(this);
            }
               
        }
    }
}
