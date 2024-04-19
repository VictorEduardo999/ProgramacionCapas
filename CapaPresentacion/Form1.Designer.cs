namespace CapaPresentacion
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnReportar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegistrar2 = new System.Windows.Forms.Button();
            this.btnReportar2 = new System.Windows.Forms.Button();
            this.txtCodigoAl = new System.Windows.Forms.TextBox();
            this.txtTelefonoAl = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(6, 254);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnReportar
            // 
            this.btnReportar.Location = new System.Drawing.Point(130, 254);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(75, 23);
            this.btnReportar.TabIndex = 1;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            this.btnReportar.Click += new System.EventHandler(this.btnReportar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 33);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(199, 22);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(6, 159);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(199, 22);
            this.txtEdad.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(41, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 400);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalir2);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.btnReportar);
            this.tabPage1.Controls.Add(this.txtEdad);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Persona";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Controls.Add(this.txtTelefonoAl);
            this.tabPage2.Controls.Add(this.txtCodigoAl);
            this.tabPage2.Controls.Add(this.btnReportar2);
            this.tabPage2.Controls.Add(this.btnRegistrar2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alumno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar2
            // 
            this.btnRegistrar2.Location = new System.Drawing.Point(24, 218);
            this.btnRegistrar2.Name = "btnRegistrar2";
            this.btnRegistrar2.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar2.TabIndex = 0;
            this.btnRegistrar2.Text = "Registrar";
            this.btnRegistrar2.UseVisualStyleBackColor = true;
            this.btnRegistrar2.Click += new System.EventHandler(this.btnRegistrar2_Click);
            // 
            // btnReportar2
            // 
            this.btnReportar2.Location = new System.Drawing.Point(159, 218);
            this.btnReportar2.Name = "btnReportar2";
            this.btnReportar2.Size = new System.Drawing.Size(75, 23);
            this.btnReportar2.TabIndex = 1;
            this.btnReportar2.Text = "Reportar";
            this.btnReportar2.UseVisualStyleBackColor = true;
            this.btnReportar2.Click += new System.EventHandler(this.btnReportar2_Click);
            // 
            // txtCodigoAl
            // 
            this.txtCodigoAl.Location = new System.Drawing.Point(24, 31);
            this.txtCodigoAl.Name = "txtCodigoAl";
            this.txtCodigoAl.Size = new System.Drawing.Size(210, 22);
            this.txtCodigoAl.TabIndex = 2;
            // 
            // txtTelefonoAl
            // 
            this.txtTelefonoAl.Location = new System.Drawing.Point(24, 102);
            this.txtTelefonoAl.Name = "txtTelefonoAl";
            this.txtTelefonoAl.Size = new System.Drawing.Size(210, 22);
            this.txtTelefonoAl.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(23, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(7, 295);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(198, 23);
            this.btnSalir2.TabIndex = 5;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTelefonoAl;
        private System.Windows.Forms.TextBox txtCodigoAl;
        private System.Windows.Forms.Button btnReportar2;
        private System.Windows.Forms.Button btnRegistrar2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSalir2;
    }
}

