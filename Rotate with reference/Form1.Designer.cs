namespace Rotate_with_reference
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
            this.button_Origem = new System.Windows.Forms.Button();
            this.textBox_OrigemX = new System.Windows.Forms.TextBox();
            this.button_Rotate = new System.Windows.Forms.Button();
            this.textBox_RefX = new System.Windows.Forms.TextBox();
            this.button_Ref = new System.Windows.Forms.Button();
            this.textBox_DestX = new System.Windows.Forms.TextBox();
            this.button_Dest = new System.Windows.Forms.Button();
            this.textBox_DestY = new System.Windows.Forms.TextBox();
            this.textBox_RefY = new System.Windows.Forms.TextBox();
            this.textBox_OrigemY = new System.Windows.Forms.TextBox();
            this.textBox_DestZ = new System.Windows.Forms.TextBox();
            this.textBox_RefZ = new System.Windows.Forms.TextBox();
            this.textBox_OrigemZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_angle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Origem
            // 
            this.button_Origem.Location = new System.Drawing.Point(12, 21);
            this.button_Origem.Name = "button_Origem";
            this.button_Origem.Size = new System.Drawing.Size(108, 23);
            this.button_Origem.TabIndex = 0;
            this.button_Origem.Text = "Selecionar origem";
            this.button_Origem.UseVisualStyleBackColor = true;
            this.button_Origem.Click += new System.EventHandler(this.button_Origem_Click);
            // 
            // textBox_OrigemX
            // 
            this.textBox_OrigemX.Location = new System.Drawing.Point(126, 24);
            this.textBox_OrigemX.Name = "textBox_OrigemX";
            this.textBox_OrigemX.Size = new System.Drawing.Size(52, 20);
            this.textBox_OrigemX.TabIndex = 1;
            // 
            // button_Rotate
            // 
            this.button_Rotate.Location = new System.Drawing.Point(12, 108);
            this.button_Rotate.Name = "button_Rotate";
            this.button_Rotate.Size = new System.Drawing.Size(282, 53);
            this.button_Rotate.TabIndex = 2;
            this.button_Rotate.Text = "Rotacionar";
            this.button_Rotate.UseVisualStyleBackColor = true;
            this.button_Rotate.Click += new System.EventHandler(this.button_Rotate_Click);
            // 
            // textBox_RefX
            // 
            this.textBox_RefX.Location = new System.Drawing.Point(126, 53);
            this.textBox_RefX.Name = "textBox_RefX";
            this.textBox_RefX.Size = new System.Drawing.Size(52, 20);
            this.textBox_RefX.TabIndex = 4;
            // 
            // button_Ref
            // 
            this.button_Ref.Location = new System.Drawing.Point(12, 50);
            this.button_Ref.Name = "button_Ref";
            this.button_Ref.Size = new System.Drawing.Size(108, 23);
            this.button_Ref.TabIndex = 3;
            this.button_Ref.Text = "Referência";
            this.button_Ref.UseVisualStyleBackColor = true;
            this.button_Ref.Click += new System.EventHandler(this.button_Ref_Click);
            // 
            // textBox_DestX
            // 
            this.textBox_DestX.Location = new System.Drawing.Point(126, 82);
            this.textBox_DestX.Name = "textBox_DestX";
            this.textBox_DestX.Size = new System.Drawing.Size(52, 20);
            this.textBox_DestX.TabIndex = 6;
            // 
            // button_Dest
            // 
            this.button_Dest.Location = new System.Drawing.Point(12, 79);
            this.button_Dest.Name = "button_Dest";
            this.button_Dest.Size = new System.Drawing.Size(108, 23);
            this.button_Dest.TabIndex = 5;
            this.button_Dest.Text = "Destino";
            this.button_Dest.UseVisualStyleBackColor = true;
            this.button_Dest.Click += new System.EventHandler(this.button_Dest_Click);
            // 
            // textBox_DestY
            // 
            this.textBox_DestY.Location = new System.Drawing.Point(184, 82);
            this.textBox_DestY.Name = "textBox_DestY";
            this.textBox_DestY.Size = new System.Drawing.Size(52, 20);
            this.textBox_DestY.TabIndex = 9;
            // 
            // textBox_RefY
            // 
            this.textBox_RefY.Location = new System.Drawing.Point(184, 53);
            this.textBox_RefY.Name = "textBox_RefY";
            this.textBox_RefY.Size = new System.Drawing.Size(52, 20);
            this.textBox_RefY.TabIndex = 8;
            // 
            // textBox_OrigemY
            // 
            this.textBox_OrigemY.Location = new System.Drawing.Point(184, 24);
            this.textBox_OrigemY.Name = "textBox_OrigemY";
            this.textBox_OrigemY.Size = new System.Drawing.Size(52, 20);
            this.textBox_OrigemY.TabIndex = 7;
            // 
            // textBox_DestZ
            // 
            this.textBox_DestZ.Location = new System.Drawing.Point(242, 82);
            this.textBox_DestZ.Name = "textBox_DestZ";
            this.textBox_DestZ.Size = new System.Drawing.Size(52, 20);
            this.textBox_DestZ.TabIndex = 12;
            // 
            // textBox_RefZ
            // 
            this.textBox_RefZ.Location = new System.Drawing.Point(242, 53);
            this.textBox_RefZ.Name = "textBox_RefZ";
            this.textBox_RefZ.Size = new System.Drawing.Size(52, 20);
            this.textBox_RefZ.TabIndex = 11;
            // 
            // textBox_OrigemZ
            // 
            this.textBox_OrigemZ.Location = new System.Drawing.Point(242, 24);
            this.textBox_OrigemZ.Name = "textBox_OrigemZ";
            this.textBox_OrigemZ.Size = new System.Drawing.Size(52, 20);
            this.textBox_OrigemZ.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(22, 5);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(0, 13);
            this.label_angle.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 170);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_DestZ);
            this.Controls.Add(this.textBox_RefZ);
            this.Controls.Add(this.textBox_OrigemZ);
            this.Controls.Add(this.textBox_DestY);
            this.Controls.Add(this.textBox_RefY);
            this.Controls.Add(this.textBox_OrigemY);
            this.Controls.Add(this.textBox_DestX);
            this.Controls.Add(this.button_Dest);
            this.Controls.Add(this.textBox_RefX);
            this.Controls.Add(this.button_Ref);
            this.Controls.Add(this.button_Rotate);
            this.Controls.Add(this.textBox_OrigemX);
            this.Controls.Add(this.button_Origem);
            this.Name = "Form1";
            this.Text = "Rotacionar com Referência";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Origem;
        private System.Windows.Forms.TextBox textBox_OrigemX;
        private System.Windows.Forms.Button button_Rotate;
        private System.Windows.Forms.TextBox textBox_RefX;
        private System.Windows.Forms.Button button_Ref;
        private System.Windows.Forms.TextBox textBox_DestX;
        private System.Windows.Forms.Button button_Dest;
        private System.Windows.Forms.TextBox textBox_DestY;
        private System.Windows.Forms.TextBox textBox_RefY;
        private System.Windows.Forms.TextBox textBox_OrigemY;
        private System.Windows.Forms.TextBox textBox_DestZ;
        private System.Windows.Forms.TextBox textBox_RefZ;
        private System.Windows.Forms.TextBox textBox_OrigemZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_angle;
    }
}

