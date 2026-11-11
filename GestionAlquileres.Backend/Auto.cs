
namespace GestionAlquileres.Backend
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public decimal PrecioPorDia { get; set; }
        public bool Disponible { get; set; }
    }
}

