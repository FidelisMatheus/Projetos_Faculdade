namespace DesafioFinal
{
    partial class FrmLogin
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
            this.cmdEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNomeAluno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.Enabled = false;
            this.cmdEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrar.Location = new System.Drawing.Point(193, 107);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(194, 60);
            this.cmdEntrar.TabIndex = 0;
            this.cmdEntrar.Text = "Entrar";
            this.cmdEntrar.UseVisualStyleBackColor = true;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // cbNomeAluno
            // 
            this.cbNomeAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNomeAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeAluno.FormattingEnabled = true;
            this.cbNomeAluno.Location = new System.Drawing.Point(90, 46);
            this.cbNomeAluno.Name = "cbNomeAluno";
            this.cbNomeAluno.Size = new System.Drawing.Size(424, 32);
            this.cbNomeAluno.TabIndex = 3;
            this.cbNomeAluno.SelectedIndexChanged += new System.EventHandler(this.cbNomeAluno_SelectedIndexChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(138)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 199);
            this.Controls.Add(this.cbNomeAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomeAluno;
    }
}