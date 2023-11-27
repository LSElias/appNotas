
namespace appNotas.Capas.GUI
{
    partial class Inicio
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
            this.lblTema = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJean = new System.Windows.Forms.Label();
            this.lblAnthony = new System.Windows.Forms.Label();
            this.lblElias = new System.Windows.Forms.Label();
            this.lblTylinn = new System.Windows.Forms.Label();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTema.Location = new System.Drawing.Point(402, 65);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(147, 29);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Laboratorio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTylinn);
            this.groupBox1.Controls.Add(this.lblElias);
            this.groupBox1.Controls.Add(this.lblAnthony);
            this.groupBox1.Controls.Add(this.lblJean);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(207, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compañeros";
            // 
            // lblJean
            // 
            this.lblJean.AutoSize = true;
            this.lblJean.Location = new System.Drawing.Point(55, 62);
            this.lblJean.Name = "lblJean";
            this.lblJean.Size = new System.Drawing.Size(344, 25);
            this.lblJean.TabIndex = 0;
            this.lblJean.Text = "Jean Franco Ávila Rojas, 2082201555";
            // 
            // lblAnthony
            // 
            this.lblAnthony.AutoSize = true;
            this.lblAnthony.Location = new System.Drawing.Point(55, 107);
            this.lblAnthony.Name = "lblAnthony";
            this.lblAnthony.Size = new System.Drawing.Size(395, 25);
            this.lblAnthony.TabIndex = 1;
            this.lblAnthony.Text = "Anthony Gerardo Badilla Nuñez, 402480474";
            // 
            // lblElias
            // 
            this.lblElias.AutoSize = true;
            this.lblElias.Location = new System.Drawing.Point(55, 151);
            this.lblElias.Name = "lblElias";
            this.lblElias.Size = new System.Drawing.Size(397, 25);
            this.lblElias.TabIndex = 2;
            this.lblElias.Text = "Elías Josué Rodríguez Guerrero, 208370217";
            // 
            // lblTylinn
            // 
            this.lblTylinn.AutoSize = true;
            this.lblTylinn.Location = new System.Drawing.Point(55, 198);
            this.lblTylinn.Name = "lblTylinn";
            this.lblTylinn.Size = new System.Drawing.Size(406, 25);
            this.lblTylinn.TabIndex = 3;
            this.lblTylinn.Text = "Tylinn Najhaby González Brenes, 208260581";
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba1.Location = new System.Drawing.Point(207, 519);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(169, 63);
            this.btnPrueba1.TabIndex = 2;
            this.btnPrueba1.Text = "Ir a prueba 1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba2.Location = new System.Drawing.Point(574, 519);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(165, 63);
            this.btnPrueba2.TabIndex = 3;
            this.btnPrueba2.Text = "Ir a prueba 2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 764);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTema);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTylinn;
        private System.Windows.Forms.Label lblElias;
        private System.Windows.Forms.Label lblAnthony;
        private System.Windows.Forms.Label lblJean;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
    }
}