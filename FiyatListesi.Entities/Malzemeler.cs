using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FiyatListesi.Entities
{
    [Table("sts_fiyat_listesi")]
    public class Malzemeler
    {
        [Key]
        public int r_sayac { get; set; }
        public string liste_kodu { get; set; }
        public string liste_adi { get; set; }
        public byte? pasif { get; set; }
        public DateTime baslangic_tarihi { get; set; }
        public DateTime bitis_tarihi { get; set; }
        public int? kategori_rsayac { get; set; }
        public string cid { get; set; }
    }
}
