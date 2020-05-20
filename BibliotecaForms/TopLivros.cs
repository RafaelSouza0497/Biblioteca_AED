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
using System.Collections;

namespace BibliotecaForms
{
    public partial class TopLivros : Form
    {
        Hashtable maisEmprestados;
        Lista ListaOrdenada = new Lista();
        public TopLivros(int[] livrosOrdenados)
        {
            maisEmprestados = new Hashtable();
            InitializeComponent();
            GetTopLivros(livrosOrdenados);
            
        }
        public void MaisImprestados(int idlivro, int ocorrencias)
        {
            Livro aux = new Livro(idlivro,ocorrencias);
            this.ListaOrdenada.Inserir(aux);
        }
        private void GetTopLivros(int[] livrosOrdenados)
        {//top 10 mais emprestados
            int i, count;
            i = count = 0;
            int temp = livrosOrdenados[0];

            for (int x = 0; x < livrosOrdenados.Length - 1; x++)
            {
                try
                {
                    while (livrosOrdenados[i] == temp)
                    {
                        count++;
                        i++;
                    }
                    //maisEmprestados.Add(livrosOrdenados[x], count);
                    MaisImprestados(livrosOrdenados[x], count);
                   temp = livrosOrdenados[i + 1];
                    count = 0;

                    x = i;
                }
                catch (IndexOutOfRangeException)
                {
                    i = 0;
                    break;
                }
            }

            CalculaMaior();
        }


        public void CalculaMaior()
        {
            //Elemento aux = this.ListaOrdenada.prim.prox;
            //Livro primeiro = (Livro)aux.dado;
            //int maior = primeiro.Ocorrencia;
            //int idMaior;
            for (int i = 0; i < 10; i++)
            {
                Elemento aux = this.ListaOrdenada.prim.prox;
                Livro primeiro = (Livro)aux.dado;
                int maior = primeiro.Ocorrencia;
                int idMaior=0;
                while (aux != null)
                {
                    Livro atual = (Livro)aux.dado;
                    if (atual.Ocorrencia > maior)
                    {
                        maior = atual.Ocorrencia;
                        idMaior = atual.Codigo;

                    }
                    aux = aux.prox;
                }

                ListaOrdenada.LocalizarRet(idMaior);
                PreencheGrid(maior, idMaior);
            }
        }


        public void PreencheGrid(int Maior,int id)
        {
            dgvTopLivros.Rows.Add(id,Maior);
        }
        
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
