﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int year { get; set; }
        public Type Type { get; set; }
        [Required]
        public int stock { set; get; }
        public int TypeId { get; set; }
    }
}