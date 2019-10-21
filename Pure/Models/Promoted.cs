using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure.Models
{
    public class Promoted
    {
        public int Id { get; set; }

        [Required,MaxLength(300)]
        public string Title { get; set; }

        [Required,MaxLength()]
        public string Slug { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [Required,MaxLength(100)]
        public string Location { get; set; }

        public string NameUrl { get; set; }
    }
}