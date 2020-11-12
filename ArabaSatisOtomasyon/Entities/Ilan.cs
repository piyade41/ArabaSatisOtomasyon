
using ArabaSatisOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArabaSatisOtomasyon.Entities
{
    public class Ilan
    {
        public int Id { get; set; }
        public string KullaniciId { get; set; }
        public int ArabaId { get; set; }
        public string İlanAdi { get; set; }
        public string IlanKategori { get; set; }
        public DateTime IlanTarihi { get; set; }
        public int İlanGunSayisi { get; set; }
        public float Fiyat { get; set; }

        public virtual Araba Araba { get; set; }
        public virtual ApplicationUser Kullanici { get; set; }
    }
}