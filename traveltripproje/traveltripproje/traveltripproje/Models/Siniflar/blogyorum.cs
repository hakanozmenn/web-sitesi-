using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace traveltripproje.Models.Siniflar
{
    public class blogyorum
    {
        public IEnumerable<blog> deger1 { get; set; }
        public IEnumerable<yorumlar> deger2 { get; set; }
        public IEnumerable<blog> deger3 { get; set; }
    }
}