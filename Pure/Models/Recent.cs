using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure.Models
{
    public class Recent
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}