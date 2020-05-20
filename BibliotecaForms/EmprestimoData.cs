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
    public partial class EmprestimoData : Form
    {
        private Lista Emprestimos;
        public EmprestimoData(Lista Emprestimos)
        {
            this.Emprestimos = Emprestimos;
            InitializeComponent();
        }

        private void ProcuraPorData(string data)
        {
            DateTime Data = DateTime.ParseExact(data, "dd/MM/yyyy", null);
            Elemento aux = this.Emprestimos.prim.prox;
            while (aux != null)
            {
                Operacao op = (Operacao)aux.dado;
                if (op.Data.Equals(Data))
                {
                    PreencheGrid(op);
                }
                aux = aux.prox;
            }
        }

        private void PreencheGrid(Operacao nova)
        {
            dataGridView1.Rows.Add(nova.Usuario.Codigo, nova.Livro.Codigo, nova.Data);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string data = (maskedTextBox1.Text);
            ProcuraPorData(data);
        }
    }
}
