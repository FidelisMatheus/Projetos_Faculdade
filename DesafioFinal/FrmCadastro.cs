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
    public partial class FrmCadastro : Form
    {
        List<Aluno> listaAlunos = null;
        internal List<Aluno> ListaAlunos { get => listaAlunos; set => listaAlunos = value; }

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdFinalizarInscricao.Visible = true;
        }

        private void cmdFinalizarInscricao_Click(object sender, EventArgs e)
        {
            Aluno A = new Aluno();
            A.Nome = txtNome.Text;
            A.Cidade = txtCidade.Text;
            A.Idade = int.Parse(txtIdade.Text);
            A.Nivel = cbNivel.Text;
            ListaAlunos.Add(A);
            Close();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cmdFinalizarInscricao, "Clique para Finalizar");
            toolTip1.SetToolTip(cbNivel, "Nivel entre Iniciante e Intermediário");
        }
    }
}
