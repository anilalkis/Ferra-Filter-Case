using FerraFilterCase.DTO.UC_CaprazReferansDtos;
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

        /// <summary>
        /// Tüm verileri getirir.
        /// </summary>
        /// <param name="orjinal_muadil"></param>
        /// <returns></returns>
        public List<CaprazDataGridDto> GetCaprazDatas(string orjinal_muadil)
        {
            using(var context = new Context())
            {
                var result = from ferra_muadil in context.ferra_orjinal_muadil
                             where ferra_muadil.orjinal_muadil == orjinal_muadil
                             select new CaprazDataGridDto
                             {
                                 firma_adi = ferra_muadil.firma_adi,
                                 filtre_no_b = ferra_muadil.filtre_no_b
                             };
                return result.ToList();
            }
        }

        public List<OemComboBoxDto> GetFirmsByOrjinalMuadil(string orjinal_muadil)
        {
            using (var context = new Context())
            {
                var result = context.ferra_orjinal_muadil
                                    .Where(x => x.orjinal_muadil == orjinal_muadil)     
                                    .Select(x => new OemComboBoxDto
                                    {
                                        firma_adi = x.firma_adi
                                    })
                                    .ToList()             
                                    .DistinctBy(x => x.firma_adi)
                                    .ToList();

                return result;
            }
        }

        /// <summary>
        /// Çapraz Referans için tablo verilerini firma ismine göre filtreleyerek getirir. 2 parametre alıyor ilk parametre firma ismi. 2. parametreye ise istediğiniz gibi filtleme yapmak için 1 veya 2 yazabilirsiniz.
        /// </summary>
        /// <param name="firma_adi"></param>
        /// <param name="orjinal_muadil"></param>
        /// <returns></returns>
        public List<CaprazDataGridDto> GetCaprazDatasByFirm(string firma_adi , string orjinal_muadil)
        {
            using (var context = new Context())
            {
                var result = from ferra_muadil in context.ferra_orjinal_muadil
                             where ferra_muadil.orjinal_muadil == orjinal_muadil && ferra_muadil.firma_adi == firma_adi
                             select new CaprazDataGridDto
                             {
                                 firma_adi = ferra_muadil.firma_adi,
                                 filtre_no_b = ferra_muadil.filtre_no_b
                             };

                return result.ToList();
            }
        }

    }
}
