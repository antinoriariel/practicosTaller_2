using System;
using System.Windows.Forms;

namespace TP_2
{
    public partial class formulario_tp2 : Form
    {
        public formulario_tp2()
        {
            InitializeComponent();
            // Configurar eventos de validación para los TextBox
            ConfigurarValidaciones();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización del formulario
        }

        private void ConfigurarValidaciones()
        {
            // Validación para txtDni - solo números
            txtDni.KeyPress += (sender, e) =>
            {
                // Permitir solo números y teclas de control (Backspace, Delete, etc.)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Bloquear el carácter
                }
            };

            // Validación para txtNombre - solo letras y espacios
            txtNombre.KeyPress += (sender, e) =>
            {
                // Permitir solo letras, espacios y teclas de control
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true; // Bloquear el carácter
                }
            };

            // Validación para txtApellido - solo letras y espacios
            txtApellido.KeyPress += (sender, e) =>
            {
                // Permitir solo letras, espacios y teclas de control
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true; // Bloquear el carácter
                }
            };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Variable ask del tipo MsgBoxResult como se solicita
            MsgBoxResult ask;

            // Validar que todos los campos estén completos usando operadores lógicos OR
            if (string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                // Mostrar mensaje de error crítico
                MessageBox.Show("Debe Completar todos los campos",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return; // Salir del método sin continuar
            }

            // Si todos los campos están completos, mostrar mensaje de confirmación
            ask = (MsgBoxResult)MessageBox.Show("Seguro que desea insertar un nuevo Cliente?",
                                               "Confirmar Insercion",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1); // Focus en "SI"

            // Usar sentencia if para verificar la respuesta
            if (ask == MsgBoxResult.Yes)
            {
                // Modificar el label lblNyA con el nombre y apellido
                lblModificar.Text = txtNombre.Text + " " + txtApellido.Text;

                // Opcional: Mostrar mensaje de éxito
                MessageBox.Show("Cliente " + lblModificar.Text + " guardado correctamente",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                // Opcional: Limpiar los campos después de guardar
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Variable ask del tipo MsgBoxResult
            MsgBoxResult ask;

            // Validar que haya datos para eliminar (verificar si hay nombre y apellido)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("No hay cliente para eliminar",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            // Obtener el nombre completo del cliente
            string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;

            // Mostrar mensaje de advertencia con focus en "NO"
            ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + nombreCompleto,
                                               "Confirmar Eliminación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Exclamation,
                                               MessageBoxDefaultButton.Button2); // Focus en "NO"

            // Si presionó "SI", proceder con la eliminación
            if (ask == MsgBoxResult.Yes)
            {
                // Mostrar mensaje de confirmación de eliminación
                MessageBox.Show("El Cliente: " + nombreCompleto + " se eliminó correctamente",
                               "Eliminar",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                // Limpiar todos los campos usando textBox.Clear()
                txtDni.Clear();
                txtNombre.Clear();
                txtApellido.Clear();

                // Limpiar el label lblModificar
                lblModificar.Text = "modificar"; // Restaurar texto original

                // Poner el foco en el primer campo
                txtDni.Focus();
            }
            // Si presionó "NO", no hacer nada (el método termina aquí)
        }

        private void LimpiarCampos()
        {
            // Método auxiliar para limpiar todos los campos
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Focus(); // Poner el foco en el primer campo
        }
    }

    // Enumeración para compatibilidad con MsgBoxResult
    public enum MsgBoxResult
    {
        OK = 1,
        Cancel = 2,
        Abort = 3,
        Retry = 4,
        Ignore = 5,
        Yes = 6,
        No = 7
    }
}