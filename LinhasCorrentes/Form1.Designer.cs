namespace LinhasCorrentes
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
            this.btn_LCR = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_UCS = new System.Windows.Forms.Button();
            this.label_Correntes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_DistCorrentes = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LCR
            // 
            this.btn_LCR.Location = new System.Drawing.Point(138, 74);
            this.btn_LCR.Name = "btn_LCR";
            this.btn_LCR.Size = new System.Drawing.Size(123, 23);
            this.btn_LCR.TabIndex = 0;
            this.btn_LCR.Text = "Correntes Rigidas";
            this.btn_LCR.UseVisualStyleBackColor = true;
            this.btn_LCR.Click += new System.EventHandler(this.btn_LCR_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 142);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_UCS);
            this.tabPage1.Controls.Add(this.label_Correntes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.text_DistCorrentes);
            this.tabPage1.Controls.Add(this.btn_LCR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Corrente Rigida";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_UCS
            // 
            this.btn_UCS.Location = new System.Drawing.Point(9, 74);
            this.btn_UCS.Name = "btn_UCS";
            this.btn_UCS.Size = new System.Drawing.Size(123, 23);
            this.btn_UCS.TabIndex = 4;
            this.btn_UCS.Text = "Ajustar UCS";
            this.btn_UCS.UseVisualStyleBackColor = true;
            this.btn_UCS.Click += new System.EventHandler(this.btn_UCS_Click);
            // 
            // label_Correntes
            // 
            this.label_Correntes.AutoSize = true;
            this.label_Correntes.Location = new System.Drawing.Point(18, 49);
            this.label_Correntes.Name = "label_Correntes";
            this.label_Correntes.Size = new System.Drawing.Size(0, 13);
            this.label_Correntes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distancia correntes";
            // 
            // text_DistCorrentes
            // 
            this.text_DistCorrentes.Location = new System.Drawing.Point(110, 15);
            this.text_DistCorrentes.Name = "text_DistCorrentes";
            this.text_DistCorrentes.Size = new System.Drawing.Size(100, 20);
            this.text_DistCorrentes.TabIndex = 1;
            this.text_DistCorrentes.Text = "2500";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corrente Flexivel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 173);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LCR;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_DistCorrentes;
        private System.Windows.Forms.Label label_Correntes;
        private System.Windows.Forms.Button btn_UCS;
    }
}

