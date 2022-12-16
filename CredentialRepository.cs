using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    internal class CredentialRepository
    {
        public static Credential Autenticar(Credential usuario)
        {
            using (Repository dbContext = new Repository())
            {
                // EF 6
                return dbContext.Credenciais
                    .Where(u =>
                        u.Email == usuario.Email
                        && u.Senha == usuario.Senha)
                    .SingleOrDefault();

                // LINQ
                //return (Usuario)
                //    from u
                //    in contextoBd.Usuarios
                //    where u.Nome == usuario.Nome
                //        && u.Senha == usuario.Senha
                //    select u;
            }
        }
    }
}
