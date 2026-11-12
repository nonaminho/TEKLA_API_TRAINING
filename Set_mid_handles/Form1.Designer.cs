namespace Set_mid_handles
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
            this.btn_MidHandle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MidHandle
            // 
            this.btn_MidHandle.Location = new System.Drawing.Point(12, 12);
            this.btn_MidHandle.Name = "btn_MidHandle";
            this.btn_MidHandle.Size = new System.Drawing.Size(224, 70);
            this.btn_MidHandle.TabIndex = 0;
            this.btn_MidHandle.Text = "Corrigir Viga";
            this.btn_MidHandle.UseVisualStyleBackColor = true;
            this.btn_MidHandle.Click += new System.EventHandler(this.btn_MidHandle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 94);
            this.Controls.Add(this.btn_MidHandle);
            this.Name = "Form1";
            this.Text = "Corrigir importação";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MidHandle;
    }
}

