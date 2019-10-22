using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Diamond
    {
        [Key]
        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
