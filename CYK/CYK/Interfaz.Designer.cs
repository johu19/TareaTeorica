﻿namespace CYK
{
    partial class Interfaz
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
            this.labelVariables = new System.Windows.Forms.Label();
            this.labelTerminales = new System.Windows.Forms.Label();
            this.textVariables = new System.Windows.Forms.TextBox();
            this.textTerminales = new System.Windows.Forms.TextBox();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVariables
            // 
            this.labelVariables.AutoSize = true;
            this.labelVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariables.Location = new System.Drawing.Point(32, 62);
            this.labelVariables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVariables.Name = "labelVariables";
            this.labelVariables.Size = new System.Drawing.Size(261, 17);
            this.labelVariables.TabIndex = 0;
            this.labelVariables.Text = "Variables separadas por ( , ) coma";
            // 
            // labelTerminales
            // 
            this.labelTerminales.AutoSize = true;
            this.labelTerminales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminales.Location = new System.Drawing.Point(32, 126);
            this.labelTerminales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerminales.Name = "labelTerminales";
            this.labelTerminales.Size = new System.Drawing.Size(273, 17);
            this.labelTerminales.TabIndex = 1;
            this.labelTerminales.Text = "Terminales separados por ( , ) coma";
            // 
            // textVariables
            // 
            this.textVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVariables.Location = new System.Drawing.Point(315, 59);
            this.textVariables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textVariables.Name = "textVariables";
            this.textVariables.Size = new System.Drawing.Size(172, 22);
            this.textVariables.TabIndex = 2;
            this.textVariables.Text = "S,";
            // 
            // textTerminales
            // 
            this.textTerminales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTerminales.Location = new System.Drawing.Point(315, 125);
            this.textTerminales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTerminales.Name = "textTerminales";
            this.textTerminales.Size = new System.Drawing.Size(172, 22);
            this.textTerminales.TabIndex = 3;
            this.textTerminales.Text = "λ,";
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.Location = new System.Drawing.Point(35, 193);
            this.btnReestablecer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(161, 61);
            this.btnReestablecer.TabIndex = 4;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(326, 193);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(161, 61);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(522, 290);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.textTerminales);
            this.Controls.Add(this.textVariables);
            this.Controls.Add(this.labelTerminales);
            this.Controls.Add(this.labelVariables);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CYK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVariables;
        private System.Windows.Forms.Label labelTerminales;
        private System.Windows.Forms.TextBox textVariables;
        private System.Windows.Forms.TextBox textTerminales;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnContinuar;
    }
}

