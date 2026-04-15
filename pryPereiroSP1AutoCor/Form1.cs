using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace pryPereiroSP1AutoCor
{
    public partial class frmPrincipal : Form
    {
        private const string PATH_ARCHIVO = "Repuestos.txt";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permitir control, dígitos, coma o punto para decimales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // pasar sólo el nombre del archivo: frmConsultar usa Application.StartupPath internamente
            frmConsultar consultar = new frmConsultar(PATH_ARCHIVO);
            consultar.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar()
        {
            txtCodigo.Text = ""; // limpiar los textBox
            txtNombre.Text = "";
            txtPrecio.Text = "";
            // cargar el comboBox
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;
            // marcar la opción de origen Nacional
            rdbNacional.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) // si los datos son correctos
            {
                // crear un nuevo repuesto
                Repuesto nuevoRep = CrearRepuesto();
                // grabar en el archivo (usar ruta completa en la carpeta de la app)
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = Path.Combine(Application.StartupPath, PATH_ARCHIVO);
                Repuestos.GrabarRepuesto(nuevoRep);
                // restaurar la interfaz al estado inicial
                Inicializar();
            }
            else // si hay algún error
            {
                MessageBox.Show("Datos incorrectos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarDatos()
        {
            // comprobar campos no vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                return false;
            }

            // comprobar precio válido (acepta coma o punto)
            string precioText = txtPrecio.Text.Trim().Replace(',', '.');
            decimal precio;
            if (!decimal.TryParse(precioText, NumberStyles.Number, CultureInfo.InvariantCulture, out precio))
            {
                MessageBox.Show("Precio inválido. Use sólo números (ej. 12 o 12.50).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // comprobar que no exista el código (usar ruta completa)
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = Path.Combine(Application.StartupPath, PATH_ARCHIVO);
            if (Repuestos.BuscarCodigoRepuesto(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("El código ya existe. Ingrese otro código.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private Repuesto CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            Repuesto nuevoRep = new Repuesto();
            // se asignan los valores a todas sus propiedades
            nuevoRep.Codigo = txtCodigo.Text.Trim();
            nuevoRep.Nombre = txtNombre.Text.Trim();
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            // parse seguro del precio
            string precioText = txtPrecio.Text.Trim().Replace(',', '.');
            nuevoRep.Precio = decimal.Parse(precioText, NumberStyles.Number, CultureInfo.InvariantCulture);
            if (rdbNacional.Checked)
            {
                nuevoRep.Origen = "Nacional";
            }
            else
            {
                nuevoRep.Origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado con sus valores
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
