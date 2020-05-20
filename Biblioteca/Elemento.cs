namespace Biblioteca
{
    public class Elemento
    {
        public IDado dado { get; set; }
        public Elemento prox { get; set; }

        public Elemento(IDado dado)
        {
            this.dado = dado;
            this.prox = null;
        }
    }
}
