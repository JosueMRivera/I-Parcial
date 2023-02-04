
namespace IParcial
{
    partial class Ejercicio_2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero1txt = new System.Windows.Forms.TextBox();
            this.numero2txt = new System.Windows.Forms.TextBox();
            this.operacionestxt = new System.Windows.Forms.ComboBox();
            this.ejecutarbt = new System.Windows.Forms.Button();
            this.Resultadolbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // numero1txt
            // 
            this.numero1txt.Location = new System.Drawing.Point(176, 51);
            this.numero1txt.Name = "numero1txt";
            this.numero1txt.Size = new System.Drawing.Size(192, 29);
            this.numero1txt.TabIndex = 2;
            // 
            // numero2txt
            // 
            this.numero2txt.Location = new System.Drawing.Point(176, 101);
            this.numero2txt.Name = "numero2txt";
            this.numero2txt.Size = new System.Drawing.Size(192, 29);
            this.numero2txt.TabIndex = 3;
            // 
            // operacionestxt
            // 
            this.operacionestxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacionestxt.FormattingEnabled = true;
            this.operacionestxt.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"});
            this.operacionestxt.Location = new System.Drawing.Point(176, 156);
            this.operacionestxt.Name = "operacionestxt";
            this.operacionestxt.Size = new System.Drawing.Size(192, 32);
            this.operacionestxt.TabIndex = 4;
            // 
            // ejecutarbt
            // 
            this.ejecutarbt.Location = new System.Drawing.Point(176, 215);
            this.ejecutarbt.Name = "ejecutarbt";
            this.ejecutarbt.Size = new System.Drawing.Size(192, 46);
            this.ejecutarbt.TabIndex = 5;
            this.ejecutarbt.Text = "Calcular";
            this.ejecutarbt.UseVisualStyleBackColor = true;
            this.ejecutarbt.Click += new System.EventHandler(this.ejecutarbt_Click);
            // 
            // Resultadolbl
            // 
            this.Resultadolbl.AutoSize = true;
            this.Resultadolbl.Location = new System.Drawing.Point(442, 159);
            this.Resultadolbl.Name = "Resultadolbl";
            this.Resultadolbl.Size = new System.Drawing.Size(0, 24);
            this.Resultadolbl.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.Resultadolbl);
            this.Controls.Add(this.ejecutarbt);
            this.Controls.Add(this.operacionestxt);
            this.Controls.Add(this.numero2txt);
            this.Controls.Add(this.numero1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ejercicio_2";
            this.Text = "Ejercicio_2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero1txt;
        private System.Windows.Forms.TextBox numero2txt;
        private System.Windows.Forms.ComboBox operacionestxt;
        private System.Windows.Forms.Button ejecutarbt;
        private System.Windows.Forms.Label Resultadolbl;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}