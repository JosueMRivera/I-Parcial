
namespace IParcial
{
    partial class Ejercicio_6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.arreglosbt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 199);
            this.listBox1.TabIndex = 0;
            // 
            // arreglosbt
            // 
            this.arreglosbt.Location = new System.Drawing.Point(211, 26);
            this.arreglosbt.Name = "arreglosbt";
            this.arreglosbt.Size = new System.Drawing.Size(119, 43);
            this.arreglosbt.TabIndex = 1;
            this.arreglosbt.Text = "Arreglos";
            this.arreglosbt.UseVisualStyleBackColor = true;
            this.arreglosbt.Click += new System.EventHandler(this.arreglosbt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.arreglosbt);
            this.Controls.Add(this.listBox1);
            this.Name = "Ejercicio_6";
            this.Text = "Ejercicio_6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button arreglosbt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}