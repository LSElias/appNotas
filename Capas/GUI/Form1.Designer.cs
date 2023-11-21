namespace appNotas
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
            this.btnDatos = new System.Windows.Forms.Button();
            this.rTxtBDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(42, 99);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 0;
            this.btnDatos.Text = "Llamar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // rTxtBDatos
            // 
            this.rTxtBDatos.Location = new System.Drawing.Point(12, 154);
            this.rTxtBDatos.Name = "rTxtBDatos";
            this.rTxtBDatos.Size = new System.Drawing.Size(768, 229);
            this.rTxtBDatos.TabIndex = 1;
            this.rTxtBDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtBDatos);
            this.Controls.Add(this.btnDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.RichTextBox rTxtBDatos;
    }
}

