﻿namespace CYK
{
    partial class VentanaAlgoritmoCYK
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarProduccion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorProduccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.tablaProducciones = new System.Windows.Forms.ListView();
            this.columnVariables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFlecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProducciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidarConCYK = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaCYK = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCYK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarProduccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtValorProduccion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxVariables);
            this.panel1.Controls.Add(this.tablaProducciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 289);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarProduccion
            // 
            this.btnAgregarProduccion.Location = new System.Drawing.Point(471, 40);
            this.btnAgregarProduccion.Name = "btnAgregarProduccion";
            this.btnAgregarProduccion.Size = new System.Drawing.Size(101, 32);
            this.btnAgregarProduccion.TabIndex = 10;
            this.btnAgregarProduccion.Text = "Agregar";
            this.btnAgregarProduccion.UseVisualStyleBackColor = true;
            this.btnAgregarProduccion.Click += new System.EventHandler(this.btnAgregarProduccion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Producción : ";
            // 
            // txtValorProduccion
            // 
            this.txtValorProduccion.Location = new System.Drawing.Point(333, 40);
            this.txtValorProduccion.Name = "txtValorProduccion";
            this.txtValorProduccion.Size = new System.Drawing.Size(110, 22);
            this.txtValorProduccion.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "--->";
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(114, 40);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(154, 24);
            this.comboBoxVariables.TabIndex = 6;
            // 
            // tablaProducciones
            // 
            this.tablaProducciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVariables,
            this.columnFlecha,
            this.columnProducciones});
            this.tablaProducciones.Location = new System.Drawing.Point(105, 105);
            this.tablaProducciones.Name = "tablaProducciones";
            this.tablaProducciones.Size = new System.Drawing.Size(378, 165);
            this.tablaProducciones.TabIndex = 5;
            this.tablaProducciones.UseCompatibleStateImageBehavior = false;
            this.tablaProducciones.View = System.Windows.Forms.View.Details;
            // 
            // columnVariables
            // 
            this.columnVariables.Text = "Variable";
            this.columnVariables.Width = 130;
            // 
            // columnFlecha
            // 
            this.columnFlecha.Text = "";
            // 
            // columnProducciones
            // 
            this.columnProducciones.Text = "Producciones";
            this.columnProducciones.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "G {";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gramática : ";
            // 
            // btnValidarConCYK
            // 
            this.btnValidarConCYK.Location = new System.Drawing.Point(333, 38);
            this.btnValidarConCYK.Name = "btnValidarConCYK";
            this.btnValidarConCYK.Size = new System.Drawing.Size(110, 46);
            this.btnValidarConCYK.TabIndex = 4;
            this.btnValidarConCYK.Text = "Validar";
            this.btnValidarConCYK.UseVisualStyleBackColor = true;
            this.btnValidarConCYK.Click += new System.EventHandler(this.btnValidarConCYK_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(105, 38);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(213, 44);
            this.txtCadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "cadena w : ";
            // 
            // tablaCYK
            // 
            this.tablaCYK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCYK.Location = new System.Drawing.Point(105, 100);
            this.tablaCYK.Name = "tablaCYK";
            this.tablaCYK.RowTemplate.Height = 24;
            this.tablaCYK.Size = new System.Drawing.Size(452, 172);
            this.tablaCYK.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tablaCYK);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCadena);
            this.panel2.Controls.Add(this.btnValidarConCYK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 332);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALGORITMO CYK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "La gramática G NO acepta a la cadena w. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resultado : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matriz : ";
            // 
            // VentanaAlgoritmoCYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "VentanaAlgoritmoCYK";
            this.Text = "VentanaAlgoritmoCYK";
            this.Load += new System.EventHandler(this.VentanaAlgoritmoCYK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCYK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidarConCYK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaCYK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView tablaProducciones;
        private System.Windows.Forms.ColumnHeader columnVariables;
        private System.Windows.Forms.ColumnHeader columnFlecha;
        private System.Windows.Forms.ColumnHeader columnProducciones;
        private System.Windows.Forms.Button btnAgregarProduccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorProduccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxVariables;
    }
}