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
    public partial class Usuarios : Form
    {
        public ABB ArvoreUsuarios { get; }

        public Usuarios()
        {
            this.ArvoreUsuarios = new ABB();

            InitializeComponent();
            LeituraUsuarios();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeituraUsuarios()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("usuariosBib.txt");
            string linha;

            while ((linha = reader.ReadLine()) != null)
            {

                string[] dados = linha.Split(';');
                int id = int.Parse(dados[0]);
                string nome = dados[1];
                //Usuario. 
                Usuario usuario = new Usuario(id, nome);
                Nodo nodo = new Nodo(usuario);
                ArvoreUsuarios.Inserir(nodo.dado);
            }
            MessageBox.Show("Usuarios carregados");
        }
    }
}