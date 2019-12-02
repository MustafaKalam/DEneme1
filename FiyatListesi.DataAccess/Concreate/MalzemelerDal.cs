using FiyatListesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatListesi.DataAccess.Concreate
{
    public class MalzemelerDal
    {
        public List<Malzemeler> GetAll()
        {
            using (FiyatListesiContext context=new FiyatListesiContext())
            {
                var result = context.sts_fiyat_listesi.ToList();
                return result;
            }
        }
    }
}
