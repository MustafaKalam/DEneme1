using FiyatListesi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatListesi.DataAccess.Concreate
{
    public class FiyatListesiContext:DbContext
    {
        public DbSet<Malzemeler> sts_fiyat_listesi { get; set; }
    }
}
