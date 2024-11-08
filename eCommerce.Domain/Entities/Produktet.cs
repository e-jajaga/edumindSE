﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Domain.Models
{
    public class Produktet
    {
        [Key]
        public int Numri { get; set; }
        
        public String Emri { get; set; }
        
        [ForeignKey("Kategoria"), DisplayName("Kategoria")]
        public int? KategoriaNumri { get; set; }
        public virtual Kategorite Kategoria { get; set; }
        public List<Komentet> Komentet { get; set; }

    }
}
