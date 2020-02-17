namespace CalificacionLeida
{
    partial class ClassGrades
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
            this.lvlCalificacions = new System.Windows.Forms.Label();
            this.txtcalificacions = new System.Windows.Forms.TextBox();
            this.bttCaptura = new System.Windows.Forms.Button();
            this.bttRep = new System.Windows.Forms.Button();
            this.lblReprobo = new System.Windows.Forms.Label();
            this.lblPasa = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.txtNumPass = new System.Windows.Forms.Label();
            this.txtNumFail = new System.Windows.Forms.Label();
            this.txtProm = new System.Windows.Forms.Label();
            this.txtAprobo = new System.Windows.Forms.TextBox();
            this.txtReprobo = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvlCalificacions
            // 
            this.lvlCalificacions.AutoSize = true;
            this.lvlCalificacions.Location = new System.Drawing.Point(23, 37);
            this.lvlCalificacions.Name = "lvlCalificacions";
            this.lvlCalificacions.Size = new System.Drawing.Size(61, 13);
            this.lvlCalificacions.TabIndex = 2;
            this.lvlCalificacions.Text = "Calificacion";
            this.lvlCalificacions.Click += new System.EventHandler(this.Calificacions_Click);
            // 
            // txtcalificacions
            // 
            this.txtcalificacions.AllowDrop = true;
            this.txtcalificacions.Location = new System.Drawing.Point(90, 30);
            this.txtcalificacions.Multiline = true;
            this.txtcalificacions.Name = "txtcalificacions";
            this.txtcalificacions.Size = new System.Drawing.Size(100, 20);
            this.txtcalificacions.TabIndex = 3;
            this.txtcalificacions.TextChanged += new System.EventHandler(this.txtgradesPut_TextChanged);
            // 
            // bttCaptura
            // 
            this.bttCaptura.Location = new System.Drawing.Point(115, 56);
            this.bttCaptura.Name = "bttCaptura";
            this.bttCaptura.Size = new System.Drawing.Size(75, 23);
            this.bttCaptura.TabIndex = 4;
            this.bttCaptura.Text = "Captura ";
            this.bttCaptura.UseVisualStyleBackColor = true;
            this.bttCaptura.Click += new System.EventHandler(this.Captura_Click);
            // 
            // bttRep
            // 
            this.bttRep.Location = new System.Drawing.Point(39, 129);
            this.bttRep.Name = "bttRep";
            this.bttRep.Size = new System.Drawing.Size(75, 23);
            this.bttRep.TabIndex = 5;
            this.bttRep.Text = "Reporte";
            this.bttRep.UseVisualStyleBackColor = true;
            this.bttRep.Click += new System.EventHandler(this.bttRep_Click);
            // 
            // lblReprobo
            // 
            this.lblReprobo.AutoSize = true;
            this.lblReprobo.Location = new System.Drawing.Point(23, 200);
            this.lblReprobo.Name = "lblReprobo";
            this.lblReprobo.Size = new System.Drawing.Size(63, 13);
            this.lblReprobo.TabIndex = 6;
            this.lblReprobo.Text = "Reprobaron";
            // 
            // lblPasa
            // 
            this.lblPasa.AutoSize = true;
            this.lblPasa.Location = new System.Drawing.Point(23, 165);
            this.lblPasa.Name = "lblPasa";
            this.lblPasa.Size = new System.Drawing.Size(46, 13);
            this.lblPasa.TabIndex = 7;
            this.lblPasa.Text = "Pasaron";
            this.lblPasa.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(23, 246);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(51, 13);
            this.lblProm.TabIndex = 8;
            this.lblProm.Text = "Promedio";
            // 
            // txtNumPass
            // 
            this.txtNumPass.AutoSize = true;
            this.txtNumPass.Location = new System.Drawing.Point(114, 165);
            this.txtNumPass.Name = "txtNumPass";
            this.txtNumPass.Size = new System.Drawing.Size(0, 13);
            this.txtNumPass.TabIndex = 9;
            // 
            // txtNumFail
            // 
            this.txtNumFail.AutoSize = true;
            this.txtNumFail.Location = new System.Drawing.Point(114, 200);
            this.txtNumFail.Name = "txtNumFail";
            this.txtNumFail.Size = new System.Drawing.Size(0, 13);
            this.txtNumFail.TabIndex = 10;
            this.txtNumFail.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtProm
            // 
            this.txtProm.AutoSize = true;
            this.txtProm.Location = new System.Drawing.Point(96, 284);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(0, 13);
            this.txtProm.TabIndex = 11;
            // 
            // txtAprobo
            // 
            this.txtAprobo.Enabled = false;
            this.txtAprobo.Location = new System.Drawing.Point(92, 158);
            this.txtAprobo.Name = "txtAprobo";
            this.txtAprobo.Size = new System.Drawing.Size(100, 20);
            this.txtAprobo.TabIndex = 12;
            // 
            // txtReprobo
            // 
            this.txtReprobo.Enabled = false;
            this.txtReprobo.Location = new System.Drawing.Point(92, 200);
            this.txtReprobo.Name = "txtReprobo";
            this.txtReprobo.Size = new System.Drawing.Size(100, 20);
            this.txtReprobo.TabIndex = 13;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(92, 239);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 14;
            // 
            // ClassGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 318);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtReprobo);
            this.Controls.Add(this.txtAprobo);
            this.Controls.Add(this.txtProm);
            this.Controls.Add(this.txtNumFail);
            this.Controls.Add(this.txtNumPass);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblPasa);
            this.Controls.Add(this.lblReprobo);
            this.Controls.Add(this.bttRep);
            this.Controls.Add(this.bttCaptura);
            this.Controls.Add(this.txtcalificacions);
            this.Controls.Add(this.lvlCalificacions);
            this.Name = "ClassGrades";
            this.Text = "ClassGrades";
            this.Load += new System.EventHandler(this.ClassGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lvlCalificacions;
        private System.Windows.Forms.TextBox txtcalificacions;
        private System.Windows.Forms.Button bttCaptura;
        private System.Windows.Forms.Button bttRep;
        private System.Windows.Forms.Label lblReprobo;
        private System.Windows.Forms.Label lblPasa;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label txtNumPass;
        private System.Windows.Forms.Label txtNumFail;
        private System.Windows.Forms.Label txtProm;
        private System.Windows.Forms.TextBox txtAprobo;
        private System.Windows.Forms.TextBox txtReprobo;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}

