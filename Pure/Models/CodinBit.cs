using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pure.Models
{
    public class CodinBit
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Logo { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }


        [MaxLength(100)]
        public string EndText { get; set; }

       
    }
}