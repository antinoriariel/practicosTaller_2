using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            String cadena;
            cadena = txtApellido.Text + " " + txtNombre.Text;

            txtDescripcion.Text = cadena;
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si Ctrl está presionado y la tecla es S
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se permiten números en el nombre.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquea el carácter
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("No se permiten números en el apellido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquea el carácter
            }
        }

    }
}
