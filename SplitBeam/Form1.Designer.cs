namespace SplitBeam
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
            this.btnSplitBeams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSplitBeams
            // 
            this.btnSplitBeams.Location = new System.Drawing.Point(59, 12);
            this.btnSplitBeams.Name = "btnSplitBeams";
            this.btnSplitBeams.Size = new System.Drawing.Size(181, 35);
            this.btnSplitBeams.TabIndex = 0;
            this.btnSplitBeams.Text = "Split Beans";
            this.btnSplitBeams.UseVisualStyleBackColor = true;
            this.btnSplitBeams.Click += new System.EventHandler(this.btnSplitBeams_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 72);
            this.Controls.Add(this.btnSplitBeams);
            this.Name = "Form1";
            this.Text = "Split Beam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSplitBeams;
    }
}

