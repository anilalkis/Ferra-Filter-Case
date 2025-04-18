using FerraFilterCase.DTO.MainFormDtos;
using FerraFilterCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public List<MainFormDataGridDto> GetByFerraNo(string filtreNo)
        {
            using (var context = new Context())
            {
                var result = from ferraMuadil in context.ferra_orjinal_muadil
                             join filtreler in context.filtreler
                             on ferraMuadil.ferra_no_b equals filtreler.ferra_no_bosluksuz
                             where ferraMuadil.filtre_no_goster.Contains(filtreNo)
                             where ferraMuadil.sabit_degisken == ""
                             select new MainFormDataGridDto  
                             {
                                 filtre_no_göster = ferraMuadil.filtre_no_goster,
                                 firma_adi = ferraMuadil.firma_adi,
                                 ferra_no_b = ferraMuadil.ferra_no_b,
                                 filtre_durumu = filtreler.filtre_durumu,
                                 foto1 = filtreler.foto1
                             };


                return result.ToList();
            }
        }

    }
}
