using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Drink
    {
        [HiddenInput]
        public int id { get; set; }

        [Display(Name = "Drink Name")]
        public string drinkName { get; set; }

        [Display(Name = "Description")]
        public string drinkDescription { get; set; }

        // public string drinkPhoto { get; set; }

        [Display(Name = "Price")]
        public double drinkPrice { get; set; }
    }
}
