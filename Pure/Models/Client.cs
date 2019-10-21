using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure.Models
{
    public class Client
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required,MaxLength(50)]
        public string Work { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }
    }
}