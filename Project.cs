using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    [Table("tbproject")]
    internal class Project
    {
        public Int64 Id { get; set; }
        [Required]
        [StringLength(45)]
        public String Name { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime inicio { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime terminoPlanejado { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime termino { get; set; }
    }
}
