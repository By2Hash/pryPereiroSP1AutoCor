using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            frmConsultar consultar = new frmConsultar();
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
                // grabar en el archivo
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = PATH_ARCHIVO;
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
            bool resultado = false;
            if (txtCodigo.Text != "") // controla el valor del código
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    if (txtPrecio.Text != "") // controla el precio
                    {
                        Archivo Repuestos = new Archivo();
                        Repuestos.NombreArchivo = PATH_ARCHIVO;
                        // controla que no se repita el codigo del repuesto
                        if (Repuestos.BuscarCodigoRepuesto(txtCodigo.Text) == false)
                        {
                            resultado = true; // devuelve verdadero sólo si todas
                                              // las condiciones se cumplieron
                        }
                    }
                }
            }
            return resultado;

        }

        private Repuesto CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            Repuesto nuevoRep = new Repuesto();
            // se asignan los valores a todas sus propiedades
            nuevoRep.Codigo = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.Precio = decimal.Parse(txtPrecio.Text);
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
