namespace DesafioFinal
{
    partial class FrmMenuAula
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
            this.scPai = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.cmdIntermediario = new System.Windows.Forms.Button();
            this.cmdIniciante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSessao4 = new System.Windows.Forms.Button();
            this.cmdSessao3 = new System.Windows.Forms.Button();
            this.cmdSessao2 = new System.Windows.Forms.Button();
            this.cmdSessao1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scPai)).BeginInit();
            this.scPai.Panel1.SuspendLayout();
            this.scPai.Panel2.SuspendLayout();
            this.scPai.SuspendLayout();
            this.SuspendLayout();
            // 
            // scPai
            // 
            this.scPai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPai.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scPai.Location = new System.Drawing.Point(0, 0);
            this.scPai.Name = "scPai";
            // 
            // scPai.Panel1
            // 
            this.scPai.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(138)))), ((int)(((byte)(192)))));
            this.scPai.Panel1.Controls.Add(this.label3);
            this.scPai.Panel1.Controls.Add(this.label2);
            this.scPai.Panel1.Controls.Add(this.lblNomeAluno);
            this.scPai.Panel1.Controls.Add(this.cmdIntermediario);
            this.scPai.Panel1.Controls.Add(this.cmdIniciante);
            // 
            // scPai.Panel2
            // 
            this.scPai.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(140)))));
            this.scPai.Panel2.Controls.Add(this.label1);
            this.scPai.Panel2.Controls.Add(this.cmdSessao4);
            this.scPai.Panel2.Controls.Add(this.cmdSessao3);
            this.scPai.Panel2.Controls.Add(this.cmdSessao2);
            this.scPai.Panel2.Controls.Add(this.cmdSessao1);
            this.scPai.Panel2.Enabled = false;
            this.scPai.Size = new System.Drawing.Size(1016, 454);
            this.scPai.SplitterDistance = 391;
            this.scPai.SplitterWidth = 10;
            this.scPai.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Acesso as Aulas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bem Vindo Aluno";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(38, 79);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(65, 25);
            this.lblNomeAluno.TabIndex = 2;
            this.lblNomeAluno.Text = "nome";
            // 
            // cmdIntermediario
            // 
            this.cmdIntermediario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIntermediario.Location = new System.Drawing.Point(94, 298);
            this.cmdIntermediario.Name = "cmdIntermediario";
            this.cmdIntermediario.Size = new System.Drawing.Size(216, 57);
            this.cmdIntermediario.TabIndex = 1;
            this.cmdIntermediario.Text = "Intermediario";
            this.cmdIntermediario.UseVisualStyleBackColor = true;
            this.cmdIntermediario.Click += new System.EventHandler(this.cmdIntermediario_Click);
            // 
            // cmdIniciante
            // 
            this.cmdIniciante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciante.Location = new System.Drawing.Point(94, 200);
            this.cmdIniciante.Name = "cmdIniciante";
            this.cmdIniciante.Size = new System.Drawing.Size(216, 57);
            this.cmdIniciante.TabIndex = 0;
            this.cmdIniciante.Text = "Iniciante";
            this.cmdIniciante.UseVisualStyleBackColor = true;
            this.cmdIniciante.Click += new System.EventHandler(this.cmdIniciante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sessões";
            // 
            // cmdSessao4
            // 
            this.cmdSessao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSessao4.Location = new System.Drawing.Point(82, 313);
            this.cmdSessao4.Name = "cmdSessao4";
            this.cmdSessao4.Size = new System.Drawing.Size(463, 57);
            this.cmdSessao4.TabIndex = 3;
            this.cmdSessao4.Text = "Sessao4";
            this.cmdSessao4.UseVisualStyleBackColor = true;
            this.cmdSessao4.Click += new System.EventHandler(this.cmdSessao4_Click);
            // 
            // cmdSessao3
            // 
            this.cmdSessao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSessao3.Location = new System.Drawing.Point(82, 233);
            this.cmdSessao3.Name = "cmdSessao3";
            this.cmdSessao3.Size = new System.Drawing.Size(463, 57);
            this.cmdSessao3.TabIndex = 2;
            this.cmdSessao3.Text = "Sessao3";
            this.cmdSessao3.UseVisualStyleBackColor = true;
            this.cmdSessao3.Click += new System.EventHandler(this.cmdSessao3_Click);
            // 
            // cmdSessao2
            // 
            this.cmdSessao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSessao2.Location = new System.Drawing.Point(82, 158);
            this.cmdSessao2.Name = "cmdSessao2";
            this.cmdSessao2.Size = new System.Drawing.Size(463, 57);
            this.cmdSessao2.TabIndex = 1;
            this.cmdSessao2.Text = "Sessao2";
            this.cmdSessao2.UseVisualStyleBackColor = true;
            this.cmdSessao2.Click += new System.EventHandler(this.cmdSessao2_Click);
            // 
            // cmdSessao1
            // 
            this.cmdSessao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSessao1.Location = new System.Drawing.Point(82, 79);
            this.cmdSessao1.Name = "cmdSessao1";
            this.cmdSessao1.Size = new System.Drawing.Size(463, 57);
            this.cmdSessao1.TabIndex = 0;
            this.cmdSessao1.Text = "Sessao1";
            this.cmdSessao1.UseVisualStyleBackColor = true;
            this.cmdSessao1.Click += new System.EventHandler(this.cmdSessao1_Click);
            // 
            // FrmMenuAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 454);
            this.Controls.Add(this.scPai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuAula";
            this.Load += new System.EventHandler(this.FrmMenuAula_Load);
            this.scPai.Panel1.ResumeLayout(false);
            this.scPai.Panel1.PerformLayout();
            this.scPai.Panel2.ResumeLayout(false);
            this.scPai.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPai)).EndInit();
            this.scPai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scPai;
        private System.Windows.Forms.Button cmdIntermediario;
        private System.Windows.Forms.Button cmdIniciante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSessao4;
        private System.Windows.Forms.Button cmdSessao3;
        private System.Windows.Forms.Button cmdSessao2;
        private System.Windows.Forms.Button cmdSessao1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}