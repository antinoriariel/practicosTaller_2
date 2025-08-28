namespace TP_1
{
    partial class Formulario1
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
            bGuardar = new Button();
            bEliminar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            lbl = new Label();
            lblDescripcion = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(48, 134);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(100, 35);
            bGuardar.TabIndex = 3;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(148, 134);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(100, 35);
            bEliminar.TabIndex = 4;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(48, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 23);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(48, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 23);
            txtApellido.TabIndex = 2;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(264, 39);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(183, 130);
            txtDescripcion.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(48, 65);
            lbl.Name = "lbl";
            lbl.Size = new Size(51, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Apellido";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(274, 21);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripcion";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(372, 177);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(490, 212);
            Controls.Add(btnSalir);
            Controls.Add(lblDescripcion);
            Controls.Add(lbl);
            Controls.Add(lblNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(bEliminar);
            Controls.Add(bGuardar);
            KeyPreview = true;
            Name = "Formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi primer forms";
            Load += Formulario1_Load;
            KeyDown += Formulario1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGuardar;
        private Button bEliminar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private Label lbl;
        private Label lblDescripcion;
        private Button btnSalir;
    }
}