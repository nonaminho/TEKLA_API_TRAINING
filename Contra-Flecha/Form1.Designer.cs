namespace Contra_Flecha
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
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Comp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Camber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomenclatura das peças";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprimento minimo";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Nome.Location = new System.Drawing.Point(144, 18);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(237, 20);
            this.textBox_Nome.TabIndex = 2;
            this.textBox_Nome.Text = "VIGA MISTA";
            // 
            // textBox_Comp
            // 
            this.textBox_Comp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Comp.Location = new System.Drawing.Point(144, 44);
            this.textBox_Comp.Name = "textBox_Comp";
            this.textBox_Comp.Size = new System.Drawing.Size(237, 20);
            this.textBox_Comp.TabIndex = 3;
            this.textBox_Comp.Text = "5000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione as peças e pressione o botão ao lado";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // button_Camber
            // 
            this.button_Camber.Location = new System.Drawing.Point(263, 72);
            this.button_Camber.Name = "button_Camber";
            this.button_Camber.Size = new System.Drawing.Size(118, 23);
            this.button_Camber.TabIndex = 5;
            this.button_Camber.Text = "Contra-Flecha";
            this.button_Camber.UseVisualStyleBackColor = true;
            this.button_Camber.Click += new System.EventHandler(this.button_Camber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(393, 102);
            this.Controls.Add(this.button_Camber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Comp);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Definir Contra-flechas em peças selecionadas";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Comp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Camber;
    }
}

