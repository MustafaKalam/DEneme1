using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiyatListesi.DataAccess.Concreate;
using FiyatListesi.Entities;

namespace FiyatListesi.Business.Concreate
{
    public class MalzemelerManager
    {
        MalzemelerDal malzemeler = new MalzemelerDal();
        public List <Malzemeler> GetAll()
        {
            return malzemeler.GetAll();
        }
    }
}
