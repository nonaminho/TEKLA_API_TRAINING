namespace Orientacao_nos
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
            this.check_NO = new System.Windows.Forms.CheckBox();
            this.check_Angulo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // check_NO
            // 
            this.check_NO.AutoSize = true;
            this.check_NO.Location = new System.Drawing.Point(12, 12);
            this.check_NO.Name = "check_NO";
            this.check_NO.Size = new System.Drawing.Size(137, 17);
            this.check_NO.TabIndex = 0;
            this.check_NO.Text = "Numerar nós das bases";
            this.check_NO.UseVisualStyleBackColor = true;
            // 
            // check_Angulo
            // 
            this.check_Angulo.AutoSize = true;
            this.check_Angulo.Location = new System.Drawing.Point(12, 35);
            this.check_Angulo.Name = "check_Angulo";
            this.check_Angulo.Size = new System.Drawing.Size(151, 17);
            this.check_Angulo.TabIndex = 1;
            this.check_Angulo.Text = "Preencher angulo da base";
            this.check_Angulo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prefixo Nó";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 92);
            this.button1.TabIndex = 4;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nó Inicial";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 108);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.check_Angulo);
            this.Controls.Add(this.check_NO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_NO;
        private System.Windows.Forms.CheckBox check_Angulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

