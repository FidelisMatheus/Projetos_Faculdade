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
    public partial class FrmTesteAprendizagem : Form
    {
        Aluno aluno = null;

        int x = 0;
        int pontos;

        public FrmTesteAprendizagem(string nomeTeste, Aluno aluno)
        {
            InitializeComponent();
            switch (nomeTeste)
            {
                case "Teste Aprendizagem I":
                    x = 1;
                    break;

                case "Teste Aprendizagem II":
                    x = 6;
                    break;

                default:
                    break;
            }
            this.aluno = aluno;
            lblNomeAluno.Text = aluno.Nome;
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            cmdIniciar.Enabled = false;
            panel1.Enabled = true;
            pontos = 0;
            lblPontos.Text = pontos.ToString();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            switch (x)
            {
                case 1:
                    lblPergunta.Text = "Sobre as cordas do violão, qual é a sequência correta de \nnotas de BAIXO para CIMA?";
                    rbOp1.Text = "MI - LA - RE - SOL - SI - MI";
                    rbOp2.Text = "MI - SI - SOL - RE - LA - MI";
                    rbOp3.Text = "MI - RE - SOL - SI - LA - MI";
                    break;
                case 2:
                    lblPergunta.Text = "Nas cifras, qual letra corresponde a nota (RÉ)";
                    rbOp1.Text = "D";
                    rbOp2.Text = "R";
                    rbOp3.Text = "M";
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Properties.Resources.C;
                    lblPergunta.Text = "Qual acorde é a apresentado ao lado ?";
                    rbOp1.Text = "A";
                    rbOp2.Text = "G";
                    rbOp3.Text = "C";
                    break;
                case 4:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Properties.Resources.Interrogacao;
                    lblPergunta.Text = "O que são acordes ?";
                    rbOp1.Text = "São notas separadas que formam um som diferente";
                    rbOp2.Text = "Uma conjunto de notas que são tocadas simultaneamente";
                    rbOp3.Text = "Notação utilizada para saber qual nota vai ser tocada";
                    break;
                case 6:
                    lblPergunta.Text = "Qual o nome dessa cifra A#";
                    rbOp1.Text = "Lá";
                    rbOp2.Text = "Lá Menor";
                    rbOp3.Text = "La Sustenido";
                    break;
                case 7:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Properties.Resources.A_Maior_7_;
                    lblPergunta.Text = "Qual é a cifra do acorde da imagem ao lado ?";
                    rbOp1.Text = "A7";
                    rbOp2.Text = "Am7+";
                    rbOp3.Text = "A7+";
                    break;
                case 8:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Properties.Resources.Interrogacao;
                    lblPergunta.Text = "Ao mover uma fôrma de um acorde o que acontece com \no mesmo?";
                    rbOp1.Text = "Se torna outro acorde perante a corda que está no baixo.";
                    rbOp2.Text = "Auxilia a fazer acordes mais complexos.";
                    rbOp3.Text = "Não muda, a nota continua a mesma.";
                    break;
                case 9:
                    lblPergunta.Text = "O que significa '#' e 'b' respectivamente?";
                    rbOp1.Text = "bemol e sustenido";
                    rbOp2.Text = "sustenido e bemol";
                    rbOp3.Text = "hashtag e be";
                    break;
                default:
                    break;
            }
        }

        private void cmdProximo_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                //Iniciante
                case 1:
                    if (rbOp2.Checked)
                        pontos++;
                    break;
                case 2:
                    if (rbOp1.Checked)
                        pontos++;
                    break;
                case 3:
                    if (rbOp3.Checked)
                        pontos++;
                    break;
                case 4:
                    if (rbOp2.Checked)
                        pontos++;
                    break;

                //Intermediario
                case 6:
                    if (rbOp3.Checked)
                        pontos++;
                    break;
                case 7:
                    if (rbOp3.Checked)
                        pontos++;
                    break;
                case 8:
                    if (rbOp1.Checked)
                        pontos++;
                    break;
                case 9:
                    if (rbOp2.Checked)
                        pontos++;
                    break;
                default:
                    break;
            }
            x++;
            lblPontos.Text = pontos.ToString();
            if (x == 5)
            {
                cmdProximo.Enabled = false;
                cmdFinalizar.Visible = true;
                if (pontos >= 3)
                {
                    MessageBox.Show("Parabéns você passou no teste !!!");
                    aluno.Nivel = "Intermediário";
                }
                else
                {
                    MessageBox.Show("Você não conseguiu passar no teste :(\nTente novamente");
                }
            } else if (x == 10)
            {
                cmdProximo.Enabled = false;
                cmdFinalizar.Visible = true;
                if (pontos >= 3)
                {
                    MessageBox.Show("Parabéns você passou no teste !!!");
                    aluno.Nivel = "Avançado";
                }
                else
                {
                    MessageBox.Show("Você não conseguiu passar no teste :(\nTente novamente");
                }
            }
            rbOp1.Checked = false;
            rbOp2.Checked = false;
            rbOp3.Checked = false;
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("G");
        }
    }
}
