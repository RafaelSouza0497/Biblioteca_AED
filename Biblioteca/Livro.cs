namespace Biblioteca
{
    public interface ILivro : IDado
    {

    }

    public class Livro : ILivro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Ocorrencia { get; set; }
        public Livro() { }
        public Livro(int id, int valor)
        {
            this.Ocorrencia = valor;
            this.Codigo = id;
        }
        public override string ToString() => $"Código: {Codigo} - Nome: {Nome}";

        public Livro(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
        public Livro(int codigo)
        {
            this.Codigo = codigo;
        }
        public bool Equals(IDado other)
        {
            Livro aux = (Livro)(other);
            return (this.Codigo == aux.Codigo);
        }
    }

    public class LivroVirtual : Livro, ILivro
    {
        public LivroVirtual(int codigo, string nome) : base(codigo, nome) { }

        public new bool Equals(IDado other)
        {
            LivroVirtual aux = (LivroVirtual)(other);
            return (this.Codigo == aux.Codigo);
        }
    }
}
