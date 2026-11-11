using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace GestionAlquileres.Backend
    {
        public class GestionClientes
        {
            private List<Cliente> clientes = new List<Cliente>();

            private readonly string archivo =
                Path.Combine(
                    System.AppDomain.CurrentDomain.BaseDirectory,
                    "clientes.xml"
                );

            public GestionClientes()
            {
                CargarClientes();
            }

            private void CargarClientes()
            {
                if (File.Exists(archivo))
                {
                    XmlSerializer serializer =
                        new XmlSerializer(typeof(List<Cliente>));

                    using (FileStream fs = File.OpenRead(archivo))
                    {
                        clientes = (List<Cliente>)serializer.Deserialize(fs);
                    }
                }
                else
                {
                    GuardarClientes();
                }
            }

            private void GuardarClientes()
            {
                XmlSerializer serializer =
                    new XmlSerializer(typeof(List<Cliente>));

                using (FileStream fs = File.Create(archivo))
                {
                    serializer.Serialize(fs, clientes);
                }
            }

            public List<Cliente> ObtenerClientes()
            {
                return clientes;
            }

            public bool AgregarClientes(Cliente cliente)
            {
                if (cliente == null ||
                    string.IsNullOrWhiteSpace(cliente.Nombre) ||
                    string.IsNullOrWhiteSpace(cliente.DNI))
                {
                    return false;
                }

                if (clientes.Any(c => c.DNI == cliente.DNI))
                {
                    return false;
                }

                clientes.Add(cliente);
                GuardarClientes();

                return true;
            }
        }
    }
