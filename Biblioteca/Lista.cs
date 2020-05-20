using System.Text;

namespace Biblioteca
{
    public class Lista
    {
        public Elemento prim, ult;

        public Lista()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        public bool Vazia()
        {
            return (this.prim == this.ult);
        }

        public IDado Retirar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.prim.prox;
            this.prim.prox = aux.prox;
            if (aux.prox != null)
                aux.prox = null;
            else
                this.ult = this.prim;

            return aux.dado;
        }

        public override string ToString()
        {
            if (this.Vazia()) return null;

            StringBuilder auxImpr = new StringBuilder();
            Elemento aux = this.prim.prox;

            while (aux != null)
            {
                auxImpr.AppendLine(aux.ToString());
                aux = aux.prox;
            }

            return auxImpr.ToString();
        }
        /// <summary>
        /// Busca dados. Precisa receber um objeto com valor igual ao que se deseja buscar.
        /// O objeto precisa ter um método sobrescrito Equals para indicar se é igual a outro objeto da mesma classe
        /// </summary>
        /// <param name="idDado">O objeto com o id a ser buscado</param>
        /// <returns>O objeto procurado ou null, caso não exista</returns>
        public IDado Buscar(int idDado)
        {
            Elemento aux = this.prim.prox;
            while (aux != null)
            {
                if (aux.dado.Codigo == (idDado)) return aux.dado;
                else aux = aux.prox;
            }
            return null;
        }
        public IDado LocalizarRet(int idDado)
        {
            if (this.Vazia()) return null;
            Elemento aux = this.prim.prox;
            Elemento ant = prim;
            while (aux != null)
            {
                if (aux.dado.Codigo == (idDado))
                {
                    ant.prox = aux.prox;
                    aux.prox = null;
                    return aux.dado;

                }

                else
                {
                    aux = aux.prox;
                    ant = ant.prox;
                }

            }
            return null;
        }
        public IDado LocalizarOperacao(int CodLivro)
        {
            if (this.Vazia()) return null;
            Elemento aux = this.prim.prox;
            Elemento ant = prim;
            while (aux != null)
            {
                Operacao op = (Operacao)aux.dado;
                if (op.Livro.Codigo == (CodLivro))
                {
                    ant.prox = aux.prox;
                    aux.prox = null;
                    return aux.dado;

                }

                else
                {
                    aux = aux.prox;
                    ant = ant.prox;
                }

            }
            return null;
        }
        public void Inserir(IDado d)
        {
            Elemento novo = new Elemento(d);

            if (this.Vazia())
            {
                this.ult.prox = novo;
                this.ult = novo;
                this.prim.prox = this.ult;
            }
            else
            {
                this.ult.prox = novo;
                this.ult = novo;
            }
        }

    }
}
