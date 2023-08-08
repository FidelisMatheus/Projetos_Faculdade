
namespace Antes_Depois
{
    partial class AntesDepois
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdImage1 = new System.Windows.Forms.Button();
            this.cmdImage2 = new System.Windows.Forms.Button();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(348, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(659, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdImage1
            // 
            this.cmdImage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImage1.FlatAppearance.BorderSize = 0;
            this.cmdImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImage1.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImage1.Location = new System.Drawing.Point(41, 56);
            this.cmdImage1.Name = "cmdImage1";
            this.cmdImage1.Size = new System.Drawing.Size(250, 35);
            this.cmdImage1.TabIndex = 3;
            this.cmdImage1.Text = "Imagem de Antes";
            this.cmdImage1.UseVisualStyleBackColor = false;
            this.cmdImage1.Click += new System.EventHandler(this.cmdImage1_Click);
            // 
            // cmdImage2
            // 
            this.cmdImage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImage2.FlatAppearance.BorderSize = 0;
            this.cmdImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImage2.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImage2.Location = new System.Drawing.Point(348, 56);
            this.cmdImage2.Name = "cmdImage2";
            this.cmdImage2.Size = new System.Drawing.Size(250, 35);
            this.cmdImage2.TabIndex = 4;
            this.cmdImage2.Text = "Imagem de Depois";
            this.cmdImage2.UseVisualStyleBackColor = false;
            this.cmdImage2.Click += new System.EventHandler(this.cmdImage2_Click);
            // 
            // cmdResultado
            // 
            this.cmdResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdResultado.FlatAppearance.BorderSize = 0;
            this.cmdResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdResultado.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResultado.Location = new System.Drawing.Point(659, 56);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(250, 35);
            this.cmdResultado.TabIndex = 5;
            this.cmdResultado.Text = "Mudança";
            this.cmdResultado.UseVisualStyleBackColor = false;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cmdLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpar.FlatAppearance.BorderSize = 0;
            this.cmdLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpar.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpar.Location = new System.Drawing.Point(933, 541);
            this.cmdLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(124, 35);
            this.cmdLimpar.TabIndex = 6;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = false;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // AntesDepois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 566);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.cmdImage2);
            this.Controls.Add(this.cmdImage1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AntesDepois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudança pós queimadas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdImage1;
        private System.Windows.Forms.Button cmdImage2;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.Button cmdLimpar;
    }
}

