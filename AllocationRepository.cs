using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    public class AllocationRepository
    {
        public static void Save(Allocation alloc)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(alloc.Developer).State = EntityState.Unchanged;
                    dbContext.Entry(alloc.Project).State = EntityState.Unchanged;
                    if (alloc.Id == 0)
                    {
                        dbContext.Allocations.Add(alloc);
                    }
                    else
                    {
                        dbContext.Entry(alloc).State
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
    }
}
