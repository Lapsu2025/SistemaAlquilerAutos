using System;
using System.Windows.Forms;
using GestionAlquileres.Backend;

namespace GestionAlquileres.UI
{
    public partial class FormClientes : Form
    {
        private GestionClientes gestion = new GestionClientes();

        public FormClientes()
        {
            InitializeComponent();

            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = gestion.ObtenerClientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Id = gestion.ObtenerClientes().Count + 1,

                Nombre = txtNombre.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()

            };

            if (!gestion.AgregarClientes(cliente))
            {
                MessageBox.Show(
                    "Ingree un nombre y un DNI válidos. El DNI no puede estar repetido");
                      return;
            }
           
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = 
    gestion.ObtenerClientes();

            txtNombre.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();

            MessageBox.Show("Cliente registrado correctamente");

        }

    }
}
