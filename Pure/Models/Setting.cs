﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pure.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Logo { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string HeaderPhone { get; set; }

        [MaxLength(50)]
        public string ContactPhone { get; set; }

        [MaxLength(100)]
        public string Adress { get; set; }

    }
}