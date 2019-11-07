﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Objects.Models
{
    public class Gun
    {
        public int id { get; set; }
        public string type { get; set; }
        public int fire_rate { get; set; }
        public int ammo { get; set; }
        public int damage { get; set; }
        public int price { get; set; }
    }
}
