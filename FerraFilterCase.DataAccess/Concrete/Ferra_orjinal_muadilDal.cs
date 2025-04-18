using FerraFilterCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerraFilterCase.DataAccess.Concrete
{
    public class Ferra_orjinal_muadilDal
    {
        public List<Ferra_orjinal_muadil> GetAll()
        {
            using (var context = new Context())
            {
                return context.ferra_orjinal_muadil.ToList();
            }
        }

        public void Add(Ferra_orjinal_muadil entity)
        {
            using (var context = new Context())
            {
                context.ferra_orjinal_muadil.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Ferra_orjinal_muadil entity)
        {
            using (var context = new Context())
            {
                context.ferra_orjinal_muadil.Update(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Ferra_orjinal_muadil entity)
        {
            using (var context = new Context())
            {
                context.ferra_orjinal_muadil.Remove(entity);
                context.SaveChanges();
            }
        }   
    }
}
