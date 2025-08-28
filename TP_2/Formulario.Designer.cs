namespace TP_2
{
    partial class formulario_tp2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNyA = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblModificar = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // lblNyA
            // 
            lblNyA.AutoSize = true;
            lblNyA.Location = new Point(27, 32);
            lblNyA.Name = "lblNyA";
            lblNyA.Size = new Size(107, 15);
            lblNyA.TabIndex = 0;
            lblNyA.Text = "Nombre y Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 123);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(27, 170);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(27, 77);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(59, 214);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(177, 214);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(177, 32);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(58, 15);
            lblModificar.TabIndex = 6;
            lblModificar.Text = "modificar";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(128, 69);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(159, 23);
            txtDni.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 162);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(159, 23);
            txtApellido.TabIndex = 9;
            // 
            // formulario_tp2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 259);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(lblModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblNyA);
            Name = "formulario_tp2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pequeño formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNyA;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblModificar;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}
