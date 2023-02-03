
namespace IParcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1txt = new System.Windows.Forms.TextBox();
            this.Numero2txt = new System.Windows.Forms.TextBox();
            this.Sumarbt = new System.Windows.Forms.Button();
            this.resultadolbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1txt
            // 
            this.Numero1txt.Location = new System.Drawing.Point(119, 37);
            this.Numero1txt.Name = "Numero1txt";
            this.Numero1txt.Size = new System.Drawing.Size(147, 20);
            this.Numero1txt.TabIndex = 2;
            // 
            // Numero2txt
            // 
            this.Numero2txt.Location = new System.Drawing.Point(119, 95);
            this.Numero2txt.Name = "Numero2txt";
            this.Numero2txt.Size = new System.Drawing.Size(147, 20);
            this.Numero2txt.TabIndex = 3;
            // 
            // Sumarbt
            // 
            this.Sumarbt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sumarbt.Location = new System.Drawing.Point(120, 141);
            this.Sumarbt.Name = "Sumarbt";
            this.Sumarbt.Size = new System.Drawing.Size(146, 32);
            this.Sumarbt.TabIndex = 4;
            this.Sumarbt.Text = "Sumar";
            this.Sumarbt.UseVisualStyleBackColor = false;
            this.Sumarbt.Click += new System.EventHandler(this.Sumarbt_Click);
            // 
            // resultadolbl
            // 
            this.resultadolbl.AutoSize = true;
            this.resultadolbl.Location = new System.Drawing.Point(117, 206);
            this.resultadolbl.Name = "resultadolbl";
            this.resultadolbl.Size = new System.Drawing.Size(0, 13);
            this.resultadolbl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultadolbl);
            this.Controls.Add(this.Sumarbt);
            this.Controls.Add(this.Numero2txt);
            this.Controls.Add(this.Numero1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1txt;
        private System.Windows.Forms.TextBox Numero2txt;
        private System.Windows.Forms.Button Sumarbt;
        private System.Windows.Forms.Label resultadolbl;
        private System.Windows.Forms.Label label3;
    }
}

