namespace Create_Spaced_Beams
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Perfil = new System.Windows.Forms.TextBox();
            this.textBox_QTD = new System.Windows.Forms.TextBox();
            this.button_Criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // textBox_Perfil
            // 
            this.textBox_Perfil.Location = new System.Drawing.Point(83, 6);
            this.textBox_Perfil.Name = "textBox_Perfil";
            this.textBox_Perfil.Size = new System.Drawing.Size(198, 20);
            this.textBox_Perfil.TabIndex = 2;
            this.textBox_Perfil.Text = "[]100*100*5";
            // 
            // textBox_QTD
            // 
            this.textBox_QTD.Location = new System.Drawing.Point(83, 32);
            this.textBox_QTD.Name = "textBox_QTD";
            this.textBox_QTD.Size = new System.Drawing.Size(198, 20);
            this.textBox_QTD.TabIndex = 3;
            // 
            // button_Criar
            // 
            this.button_Criar.Location = new System.Drawing.Point(83, 58);
            this.button_Criar.Name = "button_Criar";
            this.button_Criar.Size = new System.Drawing.Size(196, 23);
            this.button_Criar.TabIndex = 4;
            this.button_Criar.Text = "Criar Vigas";
            this.button_Criar.UseVisualStyleBackColor = true;
            this.button_Criar.Click += new System.EventHandler(this.button_Criar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 101);
            this.Controls.Add(this.button_Criar);
            this.Controls.Add(this.textBox_QTD);
            this.Controls.Add(this.textBox_Perfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Perfil;
        private System.Windows.Forms.TextBox textBox_QTD;
        private System.Windows.Forms.Button button_Criar;
    }
}

