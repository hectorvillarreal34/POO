namespace Emboteladora
{
    partial class Frmemboteladora
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
            this.lvlNivelLenado = new System.Windows.Forms.Label();
            this.txtnivellenado = new System.Windows.Forms.TextBox();
            this.btnVarify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlNivelLenado
            // 
            this.lvlNivelLenado.AutoSize = true;
            this.lvlNivelLenado.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNivelLenado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlNivelLenado.Location = new System.Drawing.Point(12, 60);
            this.lvlNivelLenado.Name = "lvlNivelLenado";
            this.lvlNivelLenado.Size = new System.Drawing.Size(277, 13);
            this.lvlNivelLenado.TabIndex = 0;
            this.lvlNivelLenado.Text = "introduce el nivel de llenado ";
            this.lvlNivelLenado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnivellenado
            // 
            this.txtnivellenado.Location = new System.Drawing.Point(300, 53);
            this.txtnivellenado.Name = "txtnivellenado";
            this.txtnivellenado.Size = new System.Drawing.Size(100, 20);
            this.txtnivellenado.TabIndex = 1;
            // 
            // btnVarify
            // 
            this.btnVarify.BackColor = System.Drawing.Color.White;
            this.btnVarify.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarify.Location = new System.Drawing.Point(307, 98);
            this.btnVarify.Name = "btnVarify";
            this.btnVarify.Size = new System.Drawing.Size(93, 30);
            this.btnVarify.TabIndex = 2;
            this.btnVarify.Text = "VERIFY";
            this.btnVarify.UseVisualStyleBackColor = false;
            this.btnVarify.Click += new System.EventHandler(this.btnVarify_Click);
            // 
            // Frmemboteladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(458, 209);
            this.Controls.Add(this.btnVarify);
            this.Controls.Add(this.txtnivellenado);
            this.Controls.Add(this.lvlNivelLenado);
            this.Name = "Frmemboteladora";
            this.Text = "AguaDeFrijoFrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlNivelLenado;
        private System.Windows.Forms.TextBox txtnivellenado;
        private System.Windows.Forms.Button btnVarify;
    }
}

