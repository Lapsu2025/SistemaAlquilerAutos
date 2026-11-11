using System;
using System.Linq;
using System.Windows.Forms;
using GestionAlquileres.Backend;

namespace GestionAlquileres.UI
{
    public partial class FormAlquileres : Form
    {
        private GestionAutos gestionAutos;
        private GestionClientes gestionClientes;

        public FormAlquileres(
            GestionAutos autos,
            GestionClientes clientes)
        {
            InitializeComponent();

            gestionAutos = autos;
            gestionClientes = clientes;

            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = gestionClientes.ObtenerClientes();
            cmbClientes.DisplayMember = "Nombre";

            CargarAutosDisponibles();

            nudDias.Minimum = 1;
            nudDias.Value = 1;

            lblPrecioTotal.Text = "Precio total: $0";

            cmbAutos.SelectedIndexChanged += cmbAutos_SelectedIndexChanged;
            nudDias.ValueChanged += nudDias_ValueChanged;
        }

        private void CargarAutosDisponibles()
        {
            cmbAutos.DataSource = null;
            cmbAutos.DataSource = gestionAutos.ObtenerAutos()
                .Where(a => a.Disponible)
                .ToList();

            cmbAutos.DisplayMember = "Modelo";
            cmbAutos.ValueMember = "Id";
        }

        private void cmbAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        private void CalcularPrecio()
        {
            if (cmbAutos.SelectedItem is Auto auto)
            {
                decimal total = auto.PrecioPorDia * nudDias.Value;
                lblPrecioTotal.Text = $"Precio total: {total:C0}";
            }
            else
            {
                lblPrecioTotal.Text = "Precio total: $0";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Primero tenés que registrar y seleccionar un cliente.");
                return;
            }

            Auto auto = cmbAutos.SelectedItem as Auto;

            if (auto == null)
            {
                MessageBox.Show("No hay autos disponibles para alquilar.");
                return;
            }
            bool alquilado = gestionAutos.AlquilarAuto(auto.Id);

            if (!alquilado)
            {
                MessageBox.Show("Ese auto ya no está disponible.");
                CargarAutosDisponibles();
                return;
            }

            MessageBox.Show("¡Alquiler confirmado!");

            CargarAutosDisponibles();
            CalcularPrecio();
        }

        private void cmbAutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

        if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona el cliente.");
                return;
            }

            Auto auto = cmbAutos.SelectedItem as Auto;

            if (auto == null)
            {
                MessageBox.Show("No hay autos disponibles.");
                return;
            }

        bool alquilado = 
        gestionAutos. AlquilarAuto(auto.Id);
            if (!alquilado)
            {
                MessageBox.Show("Ese auto ya no está disponible.");
                CargarAutosDisponibles();
                return;
            }
            MessageBox.Show("¡Alquiler confirmado!");
            CargarAutosDisponibles();
            CalcularPrecio();
        }
    }
}