using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace traveltripproje.Models.Siniflar
{
    public class anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
    }
}