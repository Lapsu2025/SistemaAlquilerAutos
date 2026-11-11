
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAlquileres.Backend;

namespace GestionAlquileres.UI
{
   public partial class Form1 : Form

    {
        private GestionAutos gestionAutos = new 
            GestionAutos();

        private GestionClientes gestionClientes = new 
            GestionClientes();


        public Form1()
        {
            InitializeComponent();
            CargarAutos();
        }

        private void CargarAutos()
        {
            
          dgvAutos.DataSource = null;
            dgvAutos.DataSource = 
                gestionAutos.ObtenerAutos();
            dgvAutos.Columns["Id"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formulario = new FormClientes();
            formulario.ShowDialog();
        }
    
        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            
            FormAlquileres formulario = new FormAlquileres(
                gestionAutos, 
                gestionClientes
                );
            formulario.ShowDialog();

             CargarAutos();
        }

        private void btnDevolverAuto_Click(object sender, EventArgs e)
        {
            if (dgvAutos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un auto de la tabla.");
                return;
            }

            int id = Convert.ToInt32(
                dgvAutos.CurrentRow.Cells["Id"].Value
            );

            DialogResult respuesta = MessageBox.Show(
                "¿Querés devolver este auto?",
                "Confirmar devolución",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                bool devuelto = gestionAutos.DevolverAuto(id);

                if (devuelto)
                {
                    MessageBox.Show("El auto volvió a estar disponible.");
                    CargarAutos();
                }
                else
                {
                    MessageBox.Show("El auto ya está disponible o no existe.");
                }

            }

        }

    }

}




