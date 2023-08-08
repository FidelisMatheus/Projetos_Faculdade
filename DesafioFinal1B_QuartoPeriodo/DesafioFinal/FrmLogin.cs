using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFinal
{
    public partial class FrmLogin : Form
    {
        List<Aluno> listaAlunos = null;
        internal List<Aluno> ListaAlunos { get => listaAlunos; set => listaAlunos = value; }
        Aluno aluno = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            foreach (Aluno x in ListaAlunos)
            {
                cbNomeAluno.Items.Add(x.Nome);
            }
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem Vindo: " + cbNomeAluno.Text);
            FrmMenuAula F = new FrmMenuAula(aluno);
            F.ListaAlunos = ListaAlunos;
            F.ShowDialog();
            Close();
        }

        private void cbNomeAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdEntrar.Enabled = true;
            int aux = cbNomeAluno.SelectedIndex;
            aluno = listaAlunos[aux];
        }
    }
}
