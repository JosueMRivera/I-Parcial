
namespace IParcial
{
    partial class Ejercicio_4
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
            this.Fechatxt = new System.Windows.Forms.DateTimePicker();
            this.ejecutartxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diatxt = new System.Windows.Forms.TextBox();
            this.mestxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.semanatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fechatxt
            // 
            this.Fechatxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fechatxt.Location = new System.Drawing.Point(246, 12);
            this.Fechatxt.Name = "Fechatxt";
            this.Fechatxt.Size = new System.Drawing.Size(102, 20);
            this.Fechatxt.TabIndex = 0;
            // 
            // ejecutartxt
            // 
            this.ejecutartxt.Location = new System.Drawing.Point(366, 9);
            this.ejecutartxt.Name = "ejecutartxt";
            this.ejecutartxt.Size = new System.Drawing.Size(75, 23);
            this.ejecutartxt.TabIndex = 1;
            this.ejecutartxt.Text = "Ejecutar";
            this.ejecutartxt.UseVisualStyleBackColor = true;
            this.ejecutartxt.Click += new System.EventHandler(this.ejecutartxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia:";
            // 
            // diatxt
            // 
            this.diatxt.Location = new System.Drawing.Point(197, 56);
            this.diatxt.Name = "diatxt";
            this.diatxt.Size = new System.Drawing.Size(107, 20);
            this.diatxt.TabIndex = 3;
            // 
            // mestxt
            // 
            this.mestxt.Location = new System.Drawing.Point(197, 94);
            this.mestxt.Name = "mestxt";
            this.mestxt.Size = new System.Drawing.Size(107, 20);
            this.mestxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes:";
            // 
            // yeartxt
            // 
            this.yeartxt.Location = new System.Drawing.Point(197, 134);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(107, 20);
            this.yeartxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año:";
            // 
            // semanatxt
            // 
            this.semanatxt.Location = new System.Drawing.Point(197, 170);
            this.semanatxt.Name = "semanatxt";
            this.semanatxt.Size = new System.Drawing.Size(107, 20);
            this.semanatxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Semana:";
            // 
            // Ejercicio_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 320);
            this.Controls.Add(this.semanatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mestxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ejecutartxt);
            this.Controls.Add(this.Fechatxt);
            this.Name = "Ejercicio_4";
            this.Text = "Ejercicio_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fechatxt;
        private System.Windows.Forms.Button ejecutartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diatxt;
        private System.Windows.Forms.TextBox mestxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox semanatxt;
        private System.Windows.Forms.Label label4;
    }
}