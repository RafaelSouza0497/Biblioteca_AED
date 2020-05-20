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

namespace BibliotecaForms
{
    public partial class VerificarStatus : Form
    {
        public ABB ArvoreUsuarios;
        public VerificarStatus(ABB ArvoreUsuarios)
        {
            this.ArvoreUsuarios = ArvoreUsuarios;
            InitializeComponent();
        }

        private void txb_Nome_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_Nome.Text);
            VerificaStatus(id);
        }
        public void VerificaStatus(int id)
        {

            Usuario atual = (Usuario)ArvoreUsuarios.Buscar(id);

            if (atual.Status)
            {
                dgvUsuarios.Rows.Add(atual.Codigo, atual.Nome, "regular");
            }
            else
            {
                dgvUsuarios.Rows.Add(atual.Codigo, atual.Nome, "suspenso");
            }

        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
