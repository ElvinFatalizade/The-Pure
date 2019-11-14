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

       
        public string Photo { get; set; }

       
        public string Title { get; set; }

      
        public string LinkName { get; set; }

      
        public float Price { get; set; }

       
        public string Text { get; set; }

       
        public string LocationName { get; set; }

        [NotMapped]
        [Required]
        public HttpPostedFileBase File { get; set; }

       
       

     
    }
}