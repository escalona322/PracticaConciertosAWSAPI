using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaConciertosAWSAPI.Models
{
    [Table("eventos")]
    public class Evento
    {
        [Key]
        [Column("IDEVENTO")]
        public int IdEvento { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("ARTISTA")]
        public string Artista { get; set; }
        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }
    }
}
