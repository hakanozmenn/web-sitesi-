﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace traveltripproje.Models.Siniflar
{
    public class hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string fotourl { get; set; }
        public string aciklama { get; set; }
    }
}