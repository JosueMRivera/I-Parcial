
namespace IParcial
{
    partial class Ejercicio_9
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
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.marcatxt = new System.Windows.Forms.TextBox();
            this.modelotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kilometrostxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CocheDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CocheDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbtn.Location = new System.Drawing.Point(312, 42);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(159, 55);
            this.Agregarbtn.TabIndex = 0;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // marcatxt
            // 
            this.marcatxt.Location = new System.Drawing.Point(82, 29);
            this.marcatxt.Name = "marcatxt";
            this.marcatxt.Size = new System.Drawing.Size(147, 20);
            this.marcatxt.TabIndex = 2;
            // 
            // modelotxt
            // 
            this.modelotxt.Location = new System.Drawing.Point(82, 56);
            this.modelotxt.Name = "modelotxt";
            this.modelotxt.Size = new System.Drawing.Size(147, 20);
            this.modelotxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo:";
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(82, 85);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(147, 20);
            this.preciotxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // kilometrostxt
            // 
            this.kilometrostxt.Location = new System.Drawing.Point(82, 116);
            this.kilometrostxt.Name = "kilometrostxt";
            this.kilometrostxt.Size = new System.Drawing.Size(147, 20);
            this.kilometrostxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometros:";
            // 
            // CocheDGV
            // 
            this.CocheDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.CocheDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CocheDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CocheDGV.Location = new System.Drawing.Point(0, 160);
            this.CocheDGV.Name = "CocheDGV";
            this.CocheDGV.Size = new System.Drawing.Size(800, 290);
            this.CocheDGV.TabIndex = 9;
            // 
            // Ejercicio_9
            // 
            this.AcceptButton = this.Agregarbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CocheDGV);
            this.Controls.Add(this.kilometrostxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marcatxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregarbtn);
            this.Name = "Ejercicio_9";
            this.Text = "Ejercicio_9";
            this.Load += new System.EventHandler(this.Ejercicio_9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CocheDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marcatxt;
        private System.Windows.Forms.TextBox modelotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kilometrostxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CocheDGV;
    }
}