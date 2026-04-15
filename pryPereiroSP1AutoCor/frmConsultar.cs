using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryPereiroSP1AutoCor
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }
        private string PATH_ARCHIVO;
        public frmConsultar(string Path) // el constructor recibe el nombre del archivo
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar()
        {
            // carga de los items en el comboBox de Marcas
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;
            // opción de Origen inicial
            rdbNacional.Checked = true;
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {

            // controlar si el archivo existe
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // leer el contenido del archivo
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = PATH_ARCHIVO;
            List<Repuesto> repuestos = Repuestos.ObtenerRepuestosOrdenados();
            // limpiar la grilla
            dgvConsulta.Rows.Clear();
            // recorrer la lista de repuestos
            foreach (Repuesto repuesto in repuestos)
            {
                // controlar el valor de la Marca
                if (repuesto.Marca == cmbMarca.SelectedItem.ToString() )
                {
                    // controlar el tipo de Origen y los botones de opción activos
                    if (rdbImportado.Checked && repuesto.Origen == "Importado")
                    {
                        // agregar el repuesto a la grilla
                        dgvConsulta.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                        repuesto.Marca, repuesto.Origen,
                        repuesto.Precio.ToString());
                    }
                    else
                    {
                        if (rdbNacional.Checked && repuesto.Origen == "Nacional")
                        {
                            // agregar el repuesto a la grilla
                            dgvConsulta.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                            repuesto.Marca, repuesto.Origen,
                            repuesto.Precio.ToString());
                        }
                        else
                        {
                            if (rdbAmbos.Checked)
                            {
                                // agregar el repuesto a la grilla
                                dgvConsulta.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                                repuesto.Marca, repuesto.Origen,
                                repuesto.Precio.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
