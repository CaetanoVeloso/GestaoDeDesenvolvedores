using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    internal class DevRepository
    {
        public static void Save(Desenvolvedor usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        dbContext.Desenvolvedores.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
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

        public static List<Desenvolvedor> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Desenvolvedor FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Desenvolvedor FindByIdWCredencial(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores
                        .Include("Credencial")
                        .Where(u => u.Id == id)
                        .FirstOrDefault<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Desenvolvedor> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Desenvolvedores
                        .Where(u => u.Nome.Contains(partialName))
                        .ToList<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Desenvolvedor usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Desenvolvedores.Attach(usuario);
                    dbContext.Desenvolvedores.Remove(usuario);

                    // OR

                    // But cascade delete fails...
                    //dbContext.Entry(usuario).State
                    //    = EntityState.Deleted;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
