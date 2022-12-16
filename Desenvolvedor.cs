using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    public class Desenvolvedor
    {
        public Int32 Id { get; set; }

        // Not null property
        [Required]
        // Maximum length value
        [StringLength(45)]
        public String Nome { get; set; }

        // Not null property
        [Required]
        // Maximum length value
        [StringLength(255)]
        public Credencial Credencial { get; set; }

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

