using System;

namespace Biblioteca
{
    public class ABB
    {
        public Nodo raiz;

        public ABB()
        {
            this.raiz = null;
        }

        private Nodo InserirRec(Nodo novo, Nodo raiz)
        {
            if (raiz == null)
                return novo;
            if (novo.CompareTo(raiz) < 0)
                raiz.esq = InserirRec(novo, raiz.esq);
            else
                raiz.dir = InserirRec(novo, raiz.dir);

            return raiz;
        }

        public void Inserir(IDado dado)
        {
            Nodo novo = new Nodo(dado);

            this.raiz = InserirRec(novo, this.raiz);
        }

        public IDado Buscar(int codigo)
        {
            IDado dado = new Usuario(codigo);
            Nodo busca = new Nodo(dado);

            return BuscaRec(busca, this.raiz).dado;
        }

        private Nodo BuscaRec(Nodo busca, Nodo raiz)
        {
            if (raiz == null)
            {
                return null;
            }
            if (busca.CompareTo(raiz) == 0)
                return raiz;
            else if (busca.CompareTo(raiz) < 0)
                return BuscaRec(busca, raiz.esq);
            else
                return BuscaRec(busca, raiz.dir);
        }


        public override string ToString()
        {
            return emOrdem(this.raiz);
        }

        private string emOrdem(Nodo raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux = emOrdem(raiz.esq);
                aux += raiz.ToString();
                aux += emOrdem(raiz.dir);
                return aux;
            }
            else return "";
        }

        private string preOrdem(Nodo raiz)
        {
            if (raiz != null)
            {
                String aux = "";
                aux += raiz.ToString();
                aux += preOrdem(raiz.esq);
                aux += preOrdem(raiz.dir);
                return aux;
            }
            else return "";
        }

    }
}

