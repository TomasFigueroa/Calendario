namespace Calendario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.Label();
            this.Btconfirmar = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(443, 185);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(0, 16);
            this.texto.TabIndex = 0;
            // 
            // Btconfirmar
            // 
            this.Btconfirmar.Location = new System.Drawing.Point(223, 242);
            this.Btconfirmar.Name = "Btconfirmar";
            this.Btconfirmar.Size = new System.Drawing.Size(122, 23);
            this.Btconfirmar.TabIndex = 1;
            this.Btconfirmar.Text = "CONFIRMAR";
            this.Btconfirmar.UseVisualStyleBackColor = true;
            this.Btconfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(319, 185);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(46, 22);
            this.TxtA.TabIndex = 2;
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(232, 185);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(48, 22);
            this.TxtMes.TabIndex = 3;
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(139, 185);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(44, 22);
            this.TxtDia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDia);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.Btconfirmar);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button Btconfirmar;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

