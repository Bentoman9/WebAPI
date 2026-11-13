using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Curso
    {
        [Key]
        public int id { get; set; }
        public string Grado { get; set; }
        public int CantidadDeVagos { get; set; }
    }
}
