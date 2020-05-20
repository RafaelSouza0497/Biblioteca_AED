using System;

namespace Biblioteca
{
    public class Usuario : IDado
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Lista Devolucoes { get; set; }

        public Lista Emprestimos = new Lista();
        public Lista Emprestados = new Lista();
        public Lista ListaVirtuaisConsultados { get; set; }
        public DateTime DataSuspensao { get; set; }
        public int QuantidadeEmprestimo { get; set; }
        public bool Status { get; set; }
        public int Pos { get; set; }
        public int PosReal { get; set; }
        public Usuario() { }

        public Usuario(int codigo)
        {
            this.Codigo = codigo;
        }

        public Usuario(int codigo, string nome)
        {
            this.Devolucoes = new Lista();
            this.Codigo = codigo;
            this.Nome = nome;
            this.Status = true;
        }

        public bool Equals(IDado obj)
        {
            Usuario aux = (Usuario)(obj);
            if (this.Codigo == aux.Codigo) return true;
            else return false;
        }

        public string ImprimirRelatorio()
        {
            return this.Emprestimos.ToString();
        }
        public bool GetStatusAtualizado()
        {
            
            if (this.DataSuspensao > DateTime.Now.Date)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            

            return this.Status;
        }
    }
}
