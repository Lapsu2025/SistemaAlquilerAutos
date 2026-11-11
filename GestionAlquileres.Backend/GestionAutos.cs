using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace GestionAlquileres.Backend
{
    public class GestionAutos
    {
        private List<Auto> autos = new List<Auto>();

        private readonly string archivo =
    Path.Combine(
        System.AppDomain.CurrentDomain.BaseDirectory,
        "autos.xml"
    );
        public GestionAutos()
        {
            CargarAutos();
        }

        private void CargarAutos()
        {
            if (File.Exists(archivo))
            {
                XmlSerializer serializer =
                    new XmlSerializer(typeof(List<Auto>));

                using (FileStream fs = File.OpenRead(archivo))
                {
                    autos = (List<Auto>)serializer.Deserialize(fs);
                }
            }
            else
            {
                CargarAutosIniciales();
                GuardarAutos();
            }
        }

        private void CargarAutosIniciales()
        {
            autos.Add(new Auto { Id = 1, Marca = "Toyota", Modelo = "Corolla", Patente = "AA101AA", PrecioPorDia = 35000, Disponible = true });
            autos.Add(new Auto { Id = 2, Marca = "Volkswagen", Modelo = "Gol", Patente = "AA102AA", PrecioPorDia = 25000, Disponible = true });
            autos.Add(new Auto { Id = 3, Marca = "Ford", Modelo = "Focus", Patente = "AA103AA", PrecioPorDia = 30000, Disponible = true });
            autos.Add(new Auto { Id = 4, Marca = "Chevrolet", Modelo = "Onix", Patente = "AA104AA", PrecioPorDia = 28000, Disponible = true });
            autos.Add(new Auto { Id = 5, Marca = "Fiat", Modelo = "Cronos", Patente = "AA105AA", PrecioPorDia = 27000, Disponible = true });
            autos.Add(new Auto { Id = 6, Marca = "Peugeot", Modelo = "208", Patente = "AA106AA", PrecioPorDia = 29000, Disponible = true });
            autos.Add(new Auto { Id = 7, Marca = "Renault", Modelo = "Logan", Patente = "AA107AA", PrecioPorDia = 26000, Disponible = true });
            autos.Add(new Auto { Id = 8, Marca = "Honda", Modelo = "Civic", Patente = "AA108AA", PrecioPorDia = 40000, Disponible = true });
            autos.Add(new Auto { Id = 9, Marca = "Nissan", Modelo = "Versa", Patente = "AA109AA", PrecioPorDia = 32000, Disponible = true });
            autos.Add(new Auto { Id = 10, Marca = "Hyundai", Modelo = "Accent", Patente = "AA110AA", PrecioPorDia = 31000, Disponible = true });
        }

        private void GuardarAutos()
        {
            XmlSerializer serializer =
                new XmlSerializer(typeof(List<Auto>));

            using (FileStream fs = File.Create(archivo))
            {
                serializer.Serialize(fs, autos);
            }
        }

        public List<Auto> ObtenerAutos()
        {
            return autos;
        }

        public bool AlquilarAuto(int id)
        {
            Auto auto = autos.FirstOrDefault(a => a.Id == id);

            if (auto == null || !auto.Disponible)
            {
                return false;
            }

            auto.Disponible = false;
            GuardarAutos();

            return true;
        }
        public bool DevolverAuto(int id)
        {
            Auto auto = autos.FirstOrDefault(a => a.Id == id);
            if (auto == null || auto.Disponible)
            {
                return false;
            }
            auto.Disponible = true;
            GuardarAutos();
            return true;
        }
    }
}