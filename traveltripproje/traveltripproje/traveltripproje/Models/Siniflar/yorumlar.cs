using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace traveltripproje.Models.Siniflar
{
    public class yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string kullaniciadi { get; set; }
        public string mail { get; set; }
        public string yorum { get; set; }
        public int blogid { get; set; }
        public virtual blog blog { get; set; }
    }
}