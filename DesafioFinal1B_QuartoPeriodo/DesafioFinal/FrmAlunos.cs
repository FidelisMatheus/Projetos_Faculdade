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
    public partial class FrmAlunos : Form
    {
        List<Aluno> listaAlunos = null;
        public List<Aluno> ListaAlunos { get => listaAlunos; set => listaAlunos = value; }

        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            foreach (Aluno x in ListaAlunos)
            {
                listBox1.Items.Add(x.mostra());
            }
        }
    }
}
