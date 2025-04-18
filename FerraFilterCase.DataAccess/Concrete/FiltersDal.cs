using FerraFilterCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerraFilterCase.DataAccess.Concrete
{
    public class FiltersDal
    {
        public List<Filters> GetAll()
        {
            using (var context = new Context())
            {
                return context.filtreler.ToList();
            }
        }

        public void Add(Filters entity)
        {
            using (var context = new Context())
            {
                context.filtreler.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Filters entity)
        {
            using (var context = new Context())
            {
                context.filtreler.Update(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Filters entity)
        {
            using (var context = new Context())
            {
                context.filtreler.Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
