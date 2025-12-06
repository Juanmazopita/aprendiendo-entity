using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace WebApplication1.Entidades
{
    public class Consultas
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName="Money" )]public decimal Costo { get; set; }
        public  int MascotaId {  get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")] public Doctores? Doctores { get; set; }
        [ForeignKey("MascotaId")] public Mascotas? Mascotas { get; set; }

    }
}
