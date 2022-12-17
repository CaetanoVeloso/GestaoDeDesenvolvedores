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
        public Char nivel { get; set; }
        public Credential Credencial { get; set; }
        public Developer(){}
        [Required]
        [StringLength(255)]
        private DateTime _nascimento;
        [Column(TypeName = "Date")]
        public DateTime Nascimento { get; set; }
    }
}

