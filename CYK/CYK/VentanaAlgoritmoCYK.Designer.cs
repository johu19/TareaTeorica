namespace CYK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLambda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCYK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnLambda);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.btnAgregarProduccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtValorProduccion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxVariables);
            this.panel1.Controls.Add(this.tablaProducciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 283);
            this.panel1.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(555, 210);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 43);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregarProduccion
            // 
            this.btnAgregarProduccion.Location = new System.Drawing.Point(460, 32);
            this.btnAgregarProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProduccion.Name = "btnAgregarProduccion";
            this.btnAgregarProduccion.Size = new System.Drawing.Size(104, 46);
            this.btnAgregarProduccion.TabIndex = 10;
            this.btnAgregarProduccion.Text = "Agregar";
            this.btnAgregarProduccion.UseVisualStyleBackColor = true;
            this.btnAgregarProduccion.Click += new System.EventHandler(this.btnAgregarProduccion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Producción : ";
            // 
            // txtValorProduccion
            // 
            this.txtValorProduccion.Location = new System.Drawing.Point(356, 43);
            this.txtValorProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorProduccion.Name = "txtValorProduccion";
            this.txtValorProduccion.Size = new System.Drawing.Size(98, 26);
            this.txtValorProduccion.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "--->";
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(196, 40);
            this.comboBoxVariables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(111, 26);
            this.comboBoxVariables.TabIndex = 6;
            // 
            // tablaProducciones
            // 
            this.tablaProducciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVariables,
            this.columnFlecha,
            this.columnProducciones});
            this.tablaProducciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaProducciones.Location = new System.Drawing.Point(120, 84);
            this.tablaProducciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaProducciones.Name = "tablaProducciones";
            this.tablaProducciones.Size = new System.Drawing.Size(429, 169);
            this.tablaProducciones.TabIndex = 5;
            this.tablaProducciones.UseCompatibleStateImageBehavior = false;
            this.tablaProducciones.View = System.Windows.Forms.View.Details;
            this.tablaProducciones.SelectedIndexChanged += new System.EventHandler(this.tablaProducciones_SelectedIndexChanged);
            // 
            // columnVariables
            // 
            this.columnVariables.Text = "Variable";
            this.columnVariables.Width = 130;
            // 
            // columnFlecha
            // 
            this.columnFlecha.Text = "";
            this.columnFlecha.Width = 83;
            // 
            // columnProducciones
            // 
            this.columnProducciones.Text = "Producciones";
            this.columnProducciones.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "G {";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gramática : ";
            // 
            // btnValidarConCYK
            // 
            this.btnValidarConCYK.Location = new System.Drawing.Point(313, 37);
            this.btnValidarConCYK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarConCYK.Name = "btnValidarConCYK";
            this.btnValidarConCYK.Size = new System.Drawing.Size(95, 43);
            this.btnValidarConCYK.TabIndex = 4;
            this.btnValidarConCYK.Text = "Validar";
            this.btnValidarConCYK.UseVisualStyleBackColor = true;
            this.btnValidarConCYK.Click += new System.EventHandler(this.btnValidarConCYK_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(120, 37);
            this.txtCadena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(187, 41);
            this.txtCadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadena w : ";
            // 
            // tablaCYK
            // 
            this.tablaCYK.AllowUserToAddRows = false;
            this.tablaCYK.AllowUserToDeleteRows = false;
            this.tablaCYK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCYK.Location = new System.Drawing.Point(89, 94);
            this.tablaCYK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaCYK.Name = "tablaCYK";
            this.tablaCYK.ReadOnly = true;
            this.tablaCYK.RowTemplate.Height = 24;
            this.tablaCYK.Size = new System.Drawing.Size(530, 176);
            this.tablaCYK.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblResultado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tablaCYK);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCadena);
            this.panel2.Controls.Add(this.btnValidarConCYK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(22, 298);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 350);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALGORITMO CYK";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultado.Location = new System.Drawing.Point(209, 300);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Resultado : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matriz : ";
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(356, 15);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(36, 23);
            this.btnLambda.TabIndex = 12;
            this.btnLambda.Text = " λ";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // VentanaAlgoritmoCYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaAlgoritmoCYK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblResultado;
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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLambda;
    }
}