using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace traveltripproje.Models.Siniflar
{
    public class blog
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public string aciklama { get; set; }
        public string blogimage { get; set; }
        public ICollection<yorumlar> yorumlars { get; set; }
    }
}