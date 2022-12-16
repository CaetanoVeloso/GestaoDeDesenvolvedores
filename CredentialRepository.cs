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
        public static void Save(Credential cred)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (cred.Id == 0)
                    {
                        dbContext.Credenciais.Add(cred);
                    }
                    else
                    {
                        dbContext.Entry(cred).State
                            = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Credential Autenticar(Credential usuario)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Credenciais
                    .Where(u =>
                        u.Email == usuario.Email
                        && u.Senha == usuario.Senha)
                    .SingleOrDefault();
            }
        }
    }
}
