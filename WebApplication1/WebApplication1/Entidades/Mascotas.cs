using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entidades
{
    public class Mascotas
    {
        [Key]public int id { get; set; }
        public string? Nombre { get; set; }
        public string? Sintomas { get; set; }
        public string? Especie { get; set; }

        public ICollection<Consultas>? Consultas { get; set; }

    }
}
