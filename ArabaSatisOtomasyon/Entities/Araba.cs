using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArabaSatisOtomasyon.Entities
{
    [Table("Araba")]
    public class Araba
    {
        public int Id { get; set; }
        public int Model;
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public int KM { get; set; }
        public int MotorHacmi { get; set; }
        public int HP { get; set; }
        public DateTime IlanTarihi { get; set; }
    }
}