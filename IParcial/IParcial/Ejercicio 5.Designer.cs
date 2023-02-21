
namespace IParcial
{
    partial class Ejercicio_5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hornearbt = new System.Windows.Forms.Button();
            this.hornearasincronabt = new System.Windows.Forms.Button();
            this.calcularbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero1txt = new System.Windows.Forms.TextBox();
            this.numero2txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hornearbt
            // 
            this.hornearbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornearbt.Location = new System.Drawing.Point(53, 29);
            this.hornearbt.Name = "hornearbt";
            this.hornearbt.Size = new System.Drawing.Size(213, 70);
            this.hornearbt.TabIndex = 0;
            this.hornearbt.Text = "Hornear Pizza";
            this.hornearbt.UseVisualStyleBackColor = true;
            this.hornearbt.Click += new System.EventHandler(this.hornearbt_Click);
            // 
            // hornearasincronabt
            // 
            this.hornearasincronabt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornearasincronabt.Location = new System.Drawing.Point(421, 29);
            this.hornearasincronabt.Name = "hornearasincronabt";
            this.hornearasincronabt.Size = new System.Drawing.Size(213, 70);
            this.hornearasincronabt.TabIndex = 1;
            this.hornearasincronabt.Text = "Hornear Pizza Asincrona";
            this.hornearasincronabt.UseVisualStyleBackColor = true;
            this.hornearasincronabt.Click += new System.EventHandler(this.hornearasincronabt_Click);
            // 
            // calcularbt
            // 
            this.calcularbt.Location = new System.Drawing.Point(122, 209);
            this.calcularbt.Name = "calcularbt";
            this.calcularbt.Size = new System.Drawing.Size(100, 38);
            this.calcularbt.TabIndex = 2;
            this.calcularbt.Text = "Calcular";
            this.calcularbt.UseVisualStyleBackColor = true;
            this.calcularbt.Click += new System.EventHandler(this.calcularbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2:";
            // 
            // numero1txt
            // 
            this.numero1txt.Location = new System.Drawing.Point(122, 150);
            this.numero1txt.Name = "numero1txt";
            this.numero1txt.Size = new System.Drawing.Size(100, 20);
            this.numero1txt.TabIndex = 5;
            // 
            // numero2txt
            // 
            this.numero2txt.Location = new System.Drawing.Point(122, 183);
            this.numero2txt.Name = "numero2txt";
            this.numero2txt.Size = new System.Drawing.Size(100, 20);
            this.numero2txt.TabIndex = 6;
            // 
            // Ejercicio_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero2txt);
            this.Controls.Add(this.numero1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularbt);
            this.Controls.Add(this.hornearasincronabt);
            this.Controls.Add(this.hornearbt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ejercicio_5";
            this.Text = "Ejercicio_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hornearbt;
        private System.Windows.Forms.Button hornearasincronabt;
        private System.Windows.Forms.Button calcularbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1txt;
        private System.Windows.Forms.TextBox numero2txt;
    }
}