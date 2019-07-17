using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heroes.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string SuperName { get; set; }

        [Display(Name = "Planet")]
        public int PlanetId { get; set; }
        public Planet Planet { get; set; }

        [Display (Name = "Category")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Super Power")]
        public string Power1 { get; set; }

        [Display(Name = "Second Power")]
        public string Power2 { get; set; }

        [Display(Name = "Third Power")]
        public string Power3 { get; set; }

        public string Universe { get; set; }
        public string Description { get; set; }
        public string Force { get; set; }
    }
}
