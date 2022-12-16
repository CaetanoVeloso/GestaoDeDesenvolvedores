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
        public Developer()
        {

        }

        // Not null property
        [Required]
        // Maximum length value
        [StringLength(255)]

        private DateTime _nascimento;

        // Only date in database
        [Column(TypeName = "Date")]
        public DateTime Nascimento
        {
            get
            {
                return _nascimento;
            }
            set
            {
                Byte idade = (Byte)(DateTime.Now.Year - value.Year);
                if (value.AddYears(idade) > DateTime.Now) { idade--; }
                Idade = idade;

                _nascimento = value;
            }
        }

        // Transient property
        [NotMapped]
        public Byte Idade { get; private set; }

        public override string ToString()
        {
            return "[" + Id.ToString("00000") + "] "
                + Nome
                + " (" + Credencial.Email + ") "
                //+ ", " + Senha 
                + Nascimento.ToString("dd/MM/yyyy")
                + " - " + Idade + " anos";
        }
    }
}

