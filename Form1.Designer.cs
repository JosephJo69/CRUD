namespace TareaCrud
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
            this.BotonSaludar = new System.Windows.Forms.Button();
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.TBCarnet = new System.Windows.Forms.MaskedTextBox();
            this.TBNombre = new System.Windows.Forms.MaskedTextBox();
            this.TBSeccion = new System.Windows.Forms.MaskedTextBox();
            this.TBCorreo = new System.Windows.Forms.MaskedTextBox();
            this.BotonCrearRegistro = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.VerDB = new System.Windows.Forms.Button();
            this.LBTarea1 = new System.Windows.Forms.Label();
            this.LBTarea2 = new System.Windows.Forms.Label();
            this.LBTarea3 = new System.Windows.Forms.Label();
            this.LBTarea4 = new System.Windows.Forms.Label();
            this.TBTarea1 = new System.Windows.Forms.TextBox();
            this.TBTarea2 = new System.Windows.Forms.TextBox();
            this.TBTarea3 = new System.Windows.Forms.TextBox();
            this.TBTarea4 = new System.Windows.Forms.TextBox();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonSaludar
            // 
            this.BotonSaludar.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSaludar.Location = new System.Drawing.Point(12, 264);
            this.BotonSaludar.Name = "BotonSaludar";
            this.BotonSaludar.Size = new System.Drawing.Size(194, 82);
            this.BotonSaludar.TabIndex = 0;
            this.BotonSaludar.Text = "Saludar";
            this.BotonSaludar.UseVisualStyleBackColor = true;
            this.BotonSaludar.Click += new System.EventHandler(this.BotonSaludar_Click);
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Location = new System.Drawing.Point(20, 58);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(41, 13);
            this.labelCarnet.TabIndex = 1;
            this.labelCarnet.Text = "Carnet ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 96);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Location = new System.Drawing.Point(20, 133);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(46, 13);
            this.labelSeccion.TabIndex = 3;
            this.labelSeccion.Text = "Seccion";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(20, 173);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correo";
            // 
            // TBCarnet
            // 
            this.TBCarnet.Location = new System.Drawing.Point(97, 58);
            this.TBCarnet.Name = "TBCarnet";
            this.TBCarnet.Size = new System.Drawing.Size(100, 20);
            this.TBCarnet.TabIndex = 6;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(97, 93);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(331, 20);
            this.TBNombre.TabIndex = 7;
            // 
            // TBSeccion
            // 
            this.TBSeccion.Location = new System.Drawing.Point(97, 133);
            this.TBSeccion.Name = "TBSeccion";
            this.TBSeccion.Size = new System.Drawing.Size(331, 20);
            this.TBSeccion.TabIndex = 8;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(97, 170);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(331, 20);
            this.TBCorreo.TabIndex = 9;
            // 
            // BotonCrearRegistro
            // 
            this.BotonCrearRegistro.Location = new System.Drawing.Point(97, 217);
            this.BotonCrearRegistro.Name = "BotonCrearRegistro";
            this.BotonCrearRegistro.Size = new System.Drawing.Size(99, 23);
            this.BotonCrearRegistro.TabIndex = 10;
            this.BotonCrearRegistro.Text = "Crear Registro";
            this.BotonCrearRegistro.UseVisualStyleBackColor = true;
            this.BotonCrearRegistro.Click += new System.EventHandler(this.BotonCrearRegistro_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(218, 56);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 11;
            this.botonBuscar.Text = "Buscar ";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // VerDB
            // 
            this.VerDB.Location = new System.Drawing.Point(654, 12);
            this.VerDB.Name = "VerDB";
            this.VerDB.Size = new System.Drawing.Size(122, 23);
            this.VerDB.TabIndex = 12;
            this.VerDB.Text = "Ver Base de datos";
            this.VerDB.UseVisualStyleBackColor = true;
            this.VerDB.Click += new System.EventHandler(this.VerDB_Click);
            // 
            // LBTarea1
            // 
            this.LBTarea1.AutoSize = true;
            this.LBTarea1.Location = new System.Drawing.Point(506, 45);
            this.LBTarea1.Name = "LBTarea1";
            this.LBTarea1.Size = new System.Drawing.Size(44, 13);
            this.LBTarea1.TabIndex = 13;
            this.LBTarea1.Text = "Tarea 1";
            // 
            // LBTarea2
            // 
            this.LBTarea2.AutoSize = true;
            this.LBTarea2.Location = new System.Drawing.Point(582, 45);
            this.LBTarea2.Name = "LBTarea2";
            this.LBTarea2.Size = new System.Drawing.Size(44, 13);
            this.LBTarea2.TabIndex = 14;
            this.LBTarea2.Text = "Tarea 2";
            // 
            // LBTarea3
            // 
            this.LBTarea3.AutoSize = true;
            this.LBTarea3.Location = new System.Drawing.Point(657, 45);
            this.LBTarea3.Name = "LBTarea3";
            this.LBTarea3.Size = new System.Drawing.Size(44, 13);
            this.LBTarea3.TabIndex = 15;
            this.LBTarea3.Text = "Tarea 3";
            // 
            // LBTarea4
            // 
            this.LBTarea4.AutoSize = true;
            this.LBTarea4.Location = new System.Drawing.Point(732, 45);
            this.LBTarea4.Name = "LBTarea4";
            this.LBTarea4.Size = new System.Drawing.Size(44, 13);
            this.LBTarea4.TabIndex = 16;
            this.LBTarea4.Text = "Tarea 4";
            // 
            // TBTarea1
            // 
            this.TBTarea1.Location = new System.Drawing.Point(509, 73);
            this.TBTarea1.Name = "TBTarea1";
            this.TBTarea1.ReadOnly = true;
            this.TBTarea1.Size = new System.Drawing.Size(32, 20);
            this.TBTarea1.TabIndex = 17;
            // 
            // TBTarea2
            // 
            this.TBTarea2.Location = new System.Drawing.Point(585, 73);
            this.TBTarea2.Name = "TBTarea2";
            this.TBTarea2.ReadOnly = true;
            this.TBTarea2.Size = new System.Drawing.Size(32, 20);
            this.TBTarea2.TabIndex = 18;
            // 
            // TBTarea3
            // 
            this.TBTarea3.Location = new System.Drawing.Point(660, 73);
            this.TBTarea3.Name = "TBTarea3";
            this.TBTarea3.ReadOnly = true;
            this.TBTarea3.Size = new System.Drawing.Size(32, 20);
            this.TBTarea3.TabIndex = 19;
            // 
            // TBTarea4
            // 
            this.TBTarea4.Location = new System.Drawing.Point(735, 73);
            this.TBTarea4.Name = "TBTarea4";
            this.TBTarea4.ReadOnly = true;
            this.TBTarea4.Size = new System.Drawing.Size(41, 20);
            this.TBTarea4.TabIndex = 20;
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.Red;
            this.botonBorrar.Location = new System.Drawing.Point(353, 56);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(75, 23);
            this.botonBorrar.TabIndex = 21;
            this.botonBorrar.Text = "BORRAR";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.TBTarea4);
            this.Controls.Add(this.TBTarea3);
            this.Controls.Add(this.TBTarea2);
            this.Controls.Add(this.TBTarea1);
            this.Controls.Add(this.LBTarea4);
            this.Controls.Add(this.LBTarea3);
            this.Controls.Add(this.LBTarea2);
            this.Controls.Add(this.LBTarea1);
            this.Controls.Add(this.VerDB);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.BotonCrearRegistro);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBSeccion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBCarnet);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCarnet);
            this.Controls.Add(this.BotonSaludar);
            this.Name = "Form1";
            this.Text = "Crud de alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonSaludar;
        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.MaskedTextBox TBCarnet;
        private System.Windows.Forms.MaskedTextBox TBNombre;
        private System.Windows.Forms.MaskedTextBox TBSeccion;
        private System.Windows.Forms.MaskedTextBox TBCorreo;
        private System.Windows.Forms.Button BotonCrearRegistro;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button VerDB;
        private System.Windows.Forms.Label LBTarea1;
        private System.Windows.Forms.Label LBTarea2;
        private System.Windows.Forms.Label LBTarea3;
        private System.Windows.Forms.Label LBTarea4;
        private System.Windows.Forms.TextBox TBTarea1;
        private System.Windows.Forms.TextBox TBTarea2;
        private System.Windows.Forms.TextBox TBTarea3;
        private System.Windows.Forms.TextBox TBTarea4;
        private System.Windows.Forms.Button botonBorrar;
    }
}

