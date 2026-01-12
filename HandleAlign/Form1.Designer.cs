namespace HandleAlign
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
            this.button_Alinhar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Alinhar
            // 
            this.button_Alinhar.Location = new System.Drawing.Point(12, 12);
            this.button_Alinhar.Name = "button_Alinhar";
            this.button_Alinhar.Size = new System.Drawing.Size(75, 23);
            this.button_Alinhar.TabIndex = 0;
            this.button_Alinhar.Text = "button1";
            this.button_Alinhar.UseVisualStyleBackColor = true;
            this.button_Alinhar.Click += new System.EventHandler(this.button_Alinhar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 244);
            this.Controls.Add(this.button_Alinhar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Alinhar;
    }
}

