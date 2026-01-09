namespace LineSplit
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
            this.button_Cut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Cut
            // 
            this.button_Cut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cut.Location = new System.Drawing.Point(12, 12);
            this.button_Cut.Name = "button_Cut";
            this.button_Cut.Size = new System.Drawing.Size(306, 78);
            this.button_Cut.TabIndex = 0;
            this.button_Cut.Text = "Cortar Peças Usando Linha";
            this.button_Cut.UseVisualStyleBackColor = true;
            this.button_Cut.Click += new System.EventHandler(this.button_Cut_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cortar Peças Usando Viga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Cut);
            this.Name = "Form1";
            this.Text = "Line Split";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cut;
        private System.Windows.Forms.Button button1;
    }
}

