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
    public partial class FrmPrincipal : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void msCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro F = new FrmCadastro();
            F.ListaAlunos = listaAlunos;
            F.ShowDialog();
        }

        private void msLogin_Click(object sender, EventArgs e)
        {
            FrmLogin F = new FrmLogin();
            F.ListaAlunos = listaAlunos;
            F.ShowDialog();
        }

        private void msAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunos F = new FrmAlunos();
            F.ListaAlunos = listaAlunos;
            F.ShowDialog();
        }
    }
}
