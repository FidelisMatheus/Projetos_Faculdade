namespace DesafioFinal
{
    partial class FrmTesteAprendizagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPontos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOp3 = new System.Windows.Forms.RadioButton();
            this.rbOp2 = new System.Windows.Forms.RadioButton();
            this.rbOp1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.cmdProximo = new System.Windows.Forms.Button();
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(138)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblPontos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbOp3);
            this.panel1.Controls.Add(this.rbOp2);
            this.panel1.Controls.Add(this.rbOp1);
            this.panel1.Controls.Add(this.lblPergunta);
            this.panel1.Controls.Add(this.cmdFinalizar);
            this.panel1.Controls.Add(this.cmdProximo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(21, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 489);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(694, 414);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(20, 24);
            this.lblPontos.TabIndex = 10;
            this.lblPontos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pontuação:";
            // 
            // rbOp3
            // 
            this.rbOp3.AutoSize = true;
            this.rbOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOp3.Location = new System.Drawing.Point(659, 222);
            this.rbOp3.Name = "rbOp3";
            this.rbOp3.Size = new System.Drawing.Size(85, 28);
            this.rbOp3.TabIndex = 8;
            this.rbOp3.TabStop = true;
            this.rbOp3.Text = "Opção";
            this.rbOp3.UseVisualStyleBackColor = true;
            // 
            // rbOp2
            // 
            this.rbOp2.AutoSize = true;
            this.rbOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOp2.Location = new System.Drawing.Point(659, 168);
            this.rbOp2.Name = "rbOp2";
            this.rbOp2.Size = new System.Drawing.Size(85, 28);
            this.rbOp2.TabIndex = 7;
            this.rbOp2.TabStop = true;
            this.rbOp2.Text = "Opção";
            this.rbOp2.UseVisualStyleBackColor = true;
            // 
            // rbOp1
            // 
            this.rbOp1.AutoSize = true;
            this.rbOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOp1.Location = new System.Drawing.Point(659, 114);
            this.rbOp1.Name = "rbOp1";
            this.rbOp1.Size = new System.Drawing.Size(85, 28);
            this.rbOp1.TabIndex = 6;
            this.rbOp1.TabStop = true;
            this.rbOp1.Text = "Opção";
            this.rbOp1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(582, 29);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(99, 25);
            this.lblPergunta.TabIndex = 5;
            this.lblPergunta.Text = "Pergunta";
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFinalizar.Location = new System.Drawing.Point(989, 404);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(160, 44);
            this.cmdFinalizar.TabIndex = 4;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Visible = false;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // cmdProximo
            // 
            this.cmdProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProximo.Location = new System.Drawing.Point(725, 306);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(276, 55);
            this.cmdProximo.TabIndex = 2;
            this.cmdProximo.Text = "Proximo";
            this.cmdProximo.UseVisualStyleBackColor = true;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.Location = new System.Drawing.Point(559, 34);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(150, 55);
            this.cmdIniciar.TabIndex = 1;
            this.cmdIniciar.Text = "Iniciar";
            this.cmdIniciar.UseVisualStyleBackColor = true;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(958, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 24);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.ForeColor = System.Drawing.Color.White;
            this.lblNomeAluno.Location = new System.Drawing.Point(90, 32);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(62, 24);
            this.lblNomeAluno.TabIndex = 3;
            this.lblNomeAluno.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(45)))));
            this.pictureBox1.BackgroundImage = global::DesafioFinal.Properties.Resources.Interrogacao;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 419);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTesteAprendizagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1267, 630);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTesteAprendizagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTesteAprendizagem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.Button cmdProximo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.RadioButton rbOp3;
        private System.Windows.Forms.RadioButton rbOp2;
        private System.Windows.Forms.RadioButton rbOp1;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeAluno;
    }
}