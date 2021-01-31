﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Models
{
    public class Laptop : BaseEntity
    { 
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Marka { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Modeli { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Madhesia { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Cpu { get; set; }
        [Required]
        [Range(0, 128)]
        public int Ram { get; set; }
        [Required]
        [Range(0,10000)]
        public int Storage { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Graphics { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Range(0, 9999.99)]
        public double Price { get; set; }
    }
}
