using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    [Table("tbcredential")]
    public class Credential
    {
        public Int64 Id { get; set; }
        public const String SALT = "1FnM6_";
        //[Required]
        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }
        private String _senha;
        [Required]
        [StringLength(64)]
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = ComputeSHA256(value, SALT);
            }
        }
        public bool Administrador { get; set; }
        [Required]
        public Developer Desenvolvedor { get; set; }
        public Credential() { }
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }
        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }
            return hash;
        }
        public override String ToString()
        {
            return Id
                + ", " + Email
                + ", " + Senha
                + ", " + (Administrador ? "Administrador" : "Usuário comum")
                + ", Usuário: " + Desenvolvedor?.Id;
        }
    }
}
