using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    [Table("tbdeveloper")]
    public class Developer
    {
        public Int64 Id { get; set; }
        [Required]
        [StringLength(45)]
        public String Nome { get; set; }
        [Required]
        public Char Nivel { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Nascimento { get; set; }
        public Credential Credential { get; set; }
        public List<Allocation> Allocations { get; set; }
        public Developer(){}
    }
}

