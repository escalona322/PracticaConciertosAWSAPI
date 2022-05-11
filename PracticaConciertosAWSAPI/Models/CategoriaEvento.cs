using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaConciertosAWSAPI.Models
{
    [Table("categoriaevento")]
    public class CategoriaEvento
    {
        [Key]
        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
    }
}
