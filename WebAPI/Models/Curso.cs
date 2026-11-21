using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Curso
    {
        [Key]
        public int id { get; set; }
        public string Grado { get; set; }

        [Range(0, 50)]
        public int CantidadDeVagos { get; set; }

        public int? NivelId { get; set; }

        [ForeignKey(nameof(NivelId))]
        public virtual Nivel? Nivel { get; set; }
    }
}
