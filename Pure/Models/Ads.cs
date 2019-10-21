using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure.Models
{
    public class Ads
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Required,MaxLength(100)]
        public string LinkName { get; set; }

        [Required]
        public float Price { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [Required,MaxLength(100)]
        public string LocationName { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}