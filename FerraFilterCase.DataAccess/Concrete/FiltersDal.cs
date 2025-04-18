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
        public List<MainFormDataGridDto> GetAll()
        {
            using (var context = new Context())
            {
                var result = from ferraMuadil in context.ferra_orjinal_muadil
                             join filtreler in context.filtreler
                             on ferraMuadil.ferra_no_b equals filtreler.ferra_no_bosluksuz
                             select new MainFormDataGridDto
                             {
                                 filtre_no_göster = ferraMuadil.filtre_no_goster,
                                 firma_adi = ferraMuadil.firma_adi,
                                 ferra_no_b = ferraMuadil.ferra_no_b,
                                 filtre_durumu = filtreler.filtre_durumu,
                                 foto1 = filtreler.foto1,
                             };

                return result.ToList();

            }
        }


        /// <summary>
        /// Arama Filtreleme Metodu
        /// </summary>
        /// <param name="filtreNo"></param>
        /// <returns></returns>
        public List<MainFormDataGridDto> GetByFerraNo(string filtreNo)
        {
            using (var context = new Context())
            {
                var firstData = from ferraMuadil in context.ferra_orjinal_muadil
                             join filtreler in context.filtreler
                             on ferraMuadil.ferra_no_b equals filtreler.ferra_no_bosluksuz
                             where ferraMuadil.filtre_no_goster.Contains(filtreNo)
                             select new   
                             {
                                 ferraMuadil.filtre_no_goster,
                                 ferraMuadil.firma_adi,
                                 ferraMuadil.ferra_no_b,
                                 filtreler.filtre_durumu,
                                 filtreler.foto1,
                                 ferraMuadil.sabit_degisken
                             };
                
                var list = firstData.ToList();

                var data = list.GroupBy(x => x.filtre_no_goster)
                    .SelectMany(g =>
                    {
                        var priority = new[] { "RD", "ND", "SD", "YD", "DD" };
                        foreach (var p in priority)
                        {
                            var matched = g.Where(x => x.sabit_degisken == p).ToList();
                            if (matched.Any())
                                return matched;
                        }
                        return Enumerable.Empty<dynamic>();

                    });

                return data.Select(x => new MainFormDataGridDto
                {
                    filtre_no_göster = x.filtre_no_goster,
                    firma_adi = x.firma_adi,
                    ferra_no_b = x.ferra_no_b,
                    filtre_durumu = x.filtre_durumu,
                    foto1 = x.foto1
                }).ToList();
            }
        }

    }
}
