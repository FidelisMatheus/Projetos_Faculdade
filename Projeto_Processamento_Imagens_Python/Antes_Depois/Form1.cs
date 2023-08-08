﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antes_Depois
{
    public partial class AntesDepois : Form
    {
        public AntesDepois()
        {
            InitializeComponent();
        }

        Bitmap image1, image2, image3;

        public string caminhoExecutavel()
        {
            string caminhoExecutavel = System.Reflection.Assembly.GetCallingAssembly().Location;
            string pastaExecutavel = new System.IO.FileInfo(caminhoExecutavel).DirectoryName;
            return pastaExecutavel += @"\";
        }

        private void cmdImage1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image1;
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;

            image1 = null;
            image2 = null;
            image3 = null;


            //ligando a biblioteca python
            ProcessStartInfo apagar = new ProcessStartInfo();
            apagar.FileName = "Python.exe";
            apagar.Arguments = "Apagar.py";
            apagar.UseShellExecute = false;
            apagar.RedirectStandardOutput = true;
            System.Diagnostics.Process.Start(apagar);

            System.Threading.Thread.Sleep(3000);
        }

        private void cmdImage2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = image2;
            }
            pictureBox3.Image = null;
        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            //Salvando a imagem no caminho do debug colocando o formato Bitmap
            pictureBox1.Image.Save(caminhoExecutavel() + "Antes.jpg", System.Drawing.Imaging.ImageFormat.Bmp);
            pictureBox2.Image.Save(caminhoExecutavel() + "Depois.jpg", System.Drawing.Imaging.ImageFormat.Bmp);

            //ligando a biblioteca python
            ProcessStartInfo x = new ProcessStartInfo();
            x.FileName = "Python.exe";
            x.Arguments = "Subtracao.py";
            x.UseShellExecute = false;
            x.RedirectStandardOutput = true;
            System.Diagnostics.Process.Start(x);

            System.Threading.Thread.Sleep(3000);

            image3 = new Bitmap(Image.FromFile(caminhoExecutavel() + "Resultado.jpg"));
            pictureBox3.Image = image3;
        }

    }
}
