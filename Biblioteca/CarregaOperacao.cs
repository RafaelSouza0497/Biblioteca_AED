using System;
using Biblioteca;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CarregaOperacao
    {
        private ABB ArvoreUsuarios;
        private List<int> topLivros { get; }

        private Lista Emprestimos = new Lista();

        public CarregaOperacao(ABB ArvoreUsuarios)
        {
            this.ArvoreUsuarios = ArvoreUsuarios;
            this.topLivros = new List<int>();

            LeituraOperacoes();
        }

        public void LeituraOperacoes()
        {
            System.IO.StreamReader reader2 = new System.IO.StreamReader("operacoes.txt");
            string linha2;

            while ((linha2 = reader2.ReadLine()) != null)
            {

                string[] dados2 = linha2.Split(';');
                int idUsuario = int.Parse(dados2[0]);
                int idLivros = int.Parse(dados2[1]);
                int operacao = int.Parse(dados2[2]);

                DateTime data = DateTime.ParseExact(dados2[3], "dd/MM/yyyy", null);

                Operacao NovaOperacao = new Operacao(idUsuario, idLivros, operacao, data);

                if (NovaOperacao.Tipo == 1)
                {
                    topLivros.Add(idLivros);
                    Emprestimos.Inserir(NovaOperacao);
                    Usuario atual = (Usuario)ArvoreUsuarios.Buscar(idUsuario);
                    atual.Emprestimos.Inserir(NovaOperacao);
                }
                else
                {
                    Usuario atual = (Usuario)ArvoreUsuarios.Buscar(idUsuario);
                    atual.Devolucoes.Inserir(NovaOperacao);

                }
            }

        }

        public int[] GetLivros() => Ordenacao.mergeSort(topLivros.ToArray());
        public Lista GetEmprestimos()
        {
            return this.Emprestimos;
        }
    }
}
