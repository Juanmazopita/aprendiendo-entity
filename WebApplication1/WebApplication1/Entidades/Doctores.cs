using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entidades
{
    public class Doctores
    {
        [Key]public int Id { get; set; }
        [MaxLength(50)] public string? Nombre { get; set; }
        public int Edad {  get; set; }
        [MaxLength(100)] public string? Especialidad { get; set; }

        public ICollection<Consultas>? Consultas { get; set; }
    }
}
