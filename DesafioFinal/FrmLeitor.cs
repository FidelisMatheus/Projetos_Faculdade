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
    public partial class FrmLeitor : Form
    {
        public FrmLeitor(string nome)
        {
            InitializeComponent();

            switch (nome)
            {
                case "Introdução":
                    axAcroPDF1.LoadFile("Introdução.pdf");
                    break;

                case "Sobre Cifras":
                    axAcroPDF1.LoadFile("Sobre as Cifras.pdf");
                    break;

                case "Músicas para Estudo I":
                    axAcroPDF1.LoadFile("Musicas para estudo I.pdf");
                    break;
                // Fim iniciante
                
                case "Entendendo Acidentes Musicais":
                    axAcroPDF1.LoadFile("Entendendo Acidentes Musicais.pdf");
                    break;

                case "Cifras+":
                    axAcroPDF1.LoadFile("Cifras+.pdf");
                    break;

                case "Músicas para Estudo II":
                    axAcroPDF1.LoadFile("Musicas para estudo II.pdf");
                    break;

                // Fim Intermediario

                default:
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            axAcroPDF1.Dispose();
        }
    }
}
