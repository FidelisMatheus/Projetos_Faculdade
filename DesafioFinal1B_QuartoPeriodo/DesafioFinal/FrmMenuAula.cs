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
    public partial class FrmMenuAula : Form
    {
        List<Aluno> listaAlunos = null;
        internal List<Aluno> ListaAlunos { get => listaAlunos; set => listaAlunos = value; }
        Aluno aluno = null;

        public FrmMenuAula(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
            lblNomeAluno.Text = aluno.Nome;
            if (aluno.Nivel == "Iniciante")
                cmdIntermediario.Enabled = false;
        }

        private void cmdIniciante_Click(object sender, EventArgs e)
        {
            scPai.Panel2.Enabled = true;
            cmdSessao1.Text = "Introdução";
            cmdSessao2.Text = "Sobre Cifras";
            cmdSessao3.Text = "Músicas para Estudo I";
            cmdSessao4.Text = "Teste Aprendizagem I";
        }

        private void cmdIntermediario_Click(object sender, EventArgs e)
        {
            scPai.Panel2.Enabled = true;
            cmdSessao1.Text = "Entendendo Acidentes Musicais";
            cmdSessao2.Text = "Cifras+";
            cmdSessao3.Text = "Músicas para Estudo II";
            cmdSessao4.Text = "Teste Aprendizagem II";
        }

        private void cmdSessao1_Click(object sender, EventArgs e)
        {
            FrmLeitor F = new FrmLeitor(cmdSessao1.Text);
            F.ShowDialog();
        }

        private void cmdSessao2_Click(object sender, EventArgs e)
        {
            FrmLeitor F = new FrmLeitor(cmdSessao2.Text);
            F.ShowDialog();
        }

        private void cmdSessao3_Click(object sender, EventArgs e)
        {
            FrmLeitor F = new FrmLeitor(cmdSessao3.Text);
            F.ShowDialog();
        }

        private void cmdSessao4_Click(object sender, EventArgs e)
        {
            FrmTesteAprendizagem F = new FrmTesteAprendizagem(cmdSessao4.Text, aluno);
            cmdIntermediario.Enabled = true;
            F.ShowDialog();
        }

        private void FrmMenuAula_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cmdIniciante, "Aulas Iniciante");
            toolTip1.SetToolTip(cmdIntermediario, "Aulas Intermediário");
        }
    }
}
