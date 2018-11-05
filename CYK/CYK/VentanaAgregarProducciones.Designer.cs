namespace CYK
{
    partial class VentanaAgregarProducciones
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorProduccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarProduccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(47, 76);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(154, 24);
            this.comboBoxVariables.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "--->";
            // 
            // txtValorProduccion
            // 
            this.txtValorProduccion.Location = new System.Drawing.Point(266, 76);
            this.txtValorProduccion.Name = "txtValorProduccion";
            this.txtValorProduccion.Size = new System.Drawing.Size(110, 22);
            this.txtValorProduccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producción : ";
            // 
            // btnAgregarProduccion
            // 
            this.btnAgregarProduccion.Location = new System.Drawing.Point(181, 128);
            this.btnAgregarProduccion.Name = "btnAgregarProduccion";
            this.btnAgregarProduccion.Size = new System.Drawing.Size(101, 32);
            this.btnAgregarProduccion.TabIndex = 4;
            this.btnAgregarProduccion.Text = "Agregar";
            this.btnAgregarProduccion.UseVisualStyleBackColor = true;
            this.btnAgregarProduccion.Click += new System.EventHandler(this.btnAgregarProduccion_Click);
            // 
            // VentanaAgregarProducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 529);
            this.Controls.Add(this.btnAgregarProduccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorProduccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVariables);
            this.Name = "VentanaAgregarProducciones";
            this.Text = "SegundaVentana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxVariables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorProduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarProduccion;
    }
}