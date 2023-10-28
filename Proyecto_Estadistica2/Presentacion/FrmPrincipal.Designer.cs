namespace Proyecto_Estadistica2
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMinimosCuadrados = new System.Windows.Forms.Button();
            this.BtnRegresionLineal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMinimosCuadrados);
            this.groupBox1.Controls.Add(this.BtnRegresionLineal);
            this.groupBox1.Location = new System.Drawing.Point(103, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelos de Regresion Simple";
            // 
            // BtnMinimosCuadrados
            // 
            this.BtnMinimosCuadrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimosCuadrados.Location = new System.Drawing.Point(6, 36);
            this.BtnMinimosCuadrados.Name = "BtnMinimosCuadrados";
            this.BtnMinimosCuadrados.Size = new System.Drawing.Size(87, 43);
            this.BtnMinimosCuadrados.TabIndex = 2;
            this.BtnMinimosCuadrados.Text = "Minimos Cuadrados";
            this.BtnMinimosCuadrados.UseVisualStyleBackColor = true;
            this.BtnMinimosCuadrados.Click += new System.EventHandler(this.BtnMinimosCuadrados_Click);
            // 
            // BtnRegresionLineal
            // 
            this.BtnRegresionLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresionLineal.Location = new System.Drawing.Point(117, 36);
            this.BtnRegresionLineal.Name = "BtnRegresionLineal";
            this.BtnRegresionLineal.Size = new System.Drawing.Size(87, 43);
            this.BtnRegresionLineal.TabIndex = 3;
            this.BtnRegresionLineal.Text = "Regresion Lineal";
            this.BtnRegresionLineal.UseVisualStyleBackColor = true;
            this.BtnRegresionLineal.Click += new System.EventHandler(this.BtnRegresionLineal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "MODELOS DE REGRESION  LINEAL SIMPLE";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(110, 196);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(86, 31);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 356);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMinimosCuadrados;
        private System.Windows.Forms.Button BtnRegresionLineal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

