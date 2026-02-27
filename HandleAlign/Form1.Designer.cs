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
            this.button_colAlign = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Alinhar
            // 
            this.button_Alinhar.Location = new System.Drawing.Point(12, 70);
            this.button_Alinhar.Name = "button_Alinhar";
            this.button_Alinhar.Size = new System.Drawing.Size(188, 23);
            this.button_Alinhar.TabIndex = 0;
            this.button_Alinhar.Text = "Alinhar com linha";
            this.button_Alinhar.UseVisualStyleBackColor = true;
            this.button_Alinhar.Click += new System.EventHandler(this.button_Alinhar_Click);
            // 
            // button_colAlign
            // 
            this.button_colAlign.Location = new System.Drawing.Point(12, 12);
            this.button_colAlign.Name = "button_colAlign";
            this.button_colAlign.Size = new System.Drawing.Size(188, 23);
            this.button_colAlign.TabIndex = 1;
            this.button_colAlign.Text = "Alinhar por Colunas";
            this.button_colAlign.UseVisualStyleBackColor = true;
            this.button_colAlign.Click += new System.EventHandler(this.button_colAlign_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alinhar por Ponto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tolerância";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "mm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_colAlign);
            this.Controls.Add(this.button_Alinhar);
            this.Name = "Form1";
            this.Text = "Alinhar handles";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Alinhar;
        private System.Windows.Forms.Button button_colAlign;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

