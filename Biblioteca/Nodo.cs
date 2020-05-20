using System;

namespace Biblioteca
{
    public class Nodo
    {
        public IDado dado { get; set; }
        public Nodo esq { get; set; }
        public Nodo dir { get; set; }

        public Nodo(IDado dado)
        {
            this.dado = dado;
        }

        public int CompareTo(Nodo raiz)
        {
            int result = 0;

            if (this.dado is Usuario)
            {
                Usuario usuario = (Usuario)(dado);
                Usuario usuarioRaiz = (Usuario)(raiz.dado);

                if (usuario.Codigo < usuarioRaiz.Codigo) result = -1;
                else if (usuario.Codigo > usuarioRaiz.Codigo) result = 1;
                //else if (this.dir == null || this.esq == null) result = 0;
                else result = 0;
            }

            return result;
        }
    }
}
