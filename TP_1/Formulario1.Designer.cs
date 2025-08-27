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
            textBox1 = new TextBox();
            lblNombre = new Label();
            lbl = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(67, 160);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(94, 35);
            bGuardar.TabIndex = 0;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += button1_Click;
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(167, 160);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(94, 35);
            bEliminar.TabIndex = 1;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(67, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 23);
            txtApellido.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 130);
            textBox1.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(67, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(51, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Apellido";
            lbl.Click += lbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Descripcion";
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(label2);
            Controls.Add(lbl);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(bEliminar);
            Controls.Add(bGuardar);
            Name = "Formulario1";
            Text = "Mi primer forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bGuardar;
        private Button bEliminar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox textBox1;
        private Label lblNombre;
        private Label lbl;
        private Label label2;
    }
}