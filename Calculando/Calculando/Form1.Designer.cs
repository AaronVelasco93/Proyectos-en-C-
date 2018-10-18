namespace Calculando
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardaRegistro = new System.Windows.Forms.Button();
            this.btnCalculaSalario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroTrabajador = new System.Windows.Forms.TextBox();
            this.txtDiasLaborales = new System.Windows.Forms.TextBox();
            this.txtPagoDia = new System.Windows.Forms.TextBox();
            this.txtTotalDePago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula un salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Trabajador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de trabajador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dias Laborados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pago por dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total a pagar";
            // 
            // btnGuardaRegistro
            // 
            this.btnGuardaRegistro.Location = new System.Drawing.Point(298, 249);
            this.btnGuardaRegistro.Name = "btnGuardaRegistro";
            this.btnGuardaRegistro.Size = new System.Drawing.Size(186, 23);
            this.btnGuardaRegistro.TabIndex = 6;
            this.btnGuardaRegistro.Text = "Guardar el Registro";
            this.btnGuardaRegistro.UseVisualStyleBackColor = true;
            this.btnGuardaRegistro.Click += new System.EventHandler(this.btnGuardaRegistro_Click);
            // 
            // btnCalculaSalario
            // 
            this.btnCalculaSalario.Location = new System.Drawing.Point(323, 289);
            this.btnCalculaSalario.Name = "btnCalculaSalario";
            this.btnCalculaSalario.Size = new System.Drawing.Size(145, 23);
            this.btnCalculaSalario.TabIndex = 7;
            this.btnCalculaSalario.Text = "Calcular salario";
            this.btnCalculaSalario.UseVisualStyleBackColor = true;
            this.btnCalculaSalario.Click += new System.EventHandler(this.btnCalculaSalario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(257, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(502, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(287, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtNumeroTrabajador
            // 
            this.txtNumeroTrabajador.Location = new System.Drawing.Point(287, 115);
            this.txtNumeroTrabajador.Name = "txtNumeroTrabajador";
            this.txtNumeroTrabajador.Size = new System.Drawing.Size(243, 20);
            this.txtNumeroTrabajador.TabIndex = 11;
            // 
            // txtDiasLaborales
            // 
            this.txtDiasLaborales.Location = new System.Drawing.Point(287, 158);
            this.txtDiasLaborales.Name = "txtDiasLaborales";
            this.txtDiasLaborales.Size = new System.Drawing.Size(243, 20);
            this.txtDiasLaborales.TabIndex = 12;
            // 
            // txtPagoDia
            // 
            this.txtPagoDia.Location = new System.Drawing.Point(287, 201);
            this.txtPagoDia.Name = "txtPagoDia";
            this.txtPagoDia.Size = new System.Drawing.Size(243, 20);
            this.txtPagoDia.TabIndex = 13;
            // 
            // txtTotalDePago
            // 
            this.txtTotalDePago.Location = new System.Drawing.Point(154, 328);
            this.txtTotalDePago.Name = "txtTotalDePago";
            this.txtTotalDePago.Size = new System.Drawing.Size(130, 20);
            this.txtTotalDePago.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalDePago);
            this.Controls.Add(this.txtPagoDia);
            this.Controls.Add(this.txtDiasLaborales);
            this.Controls.Add(this.txtNumeroTrabajador);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalculaSalario);
            this.Controls.Add(this.btnGuardaRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardaRegistro;
        private System.Windows.Forms.Button btnCalculaSalario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroTrabajador;
        private System.Windows.Forms.TextBox txtDiasLaborales;
        private System.Windows.Forms.TextBox txtPagoDia;
        private System.Windows.Forms.TextBox txtTotalDePago;
    }
}

