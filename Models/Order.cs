using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Order
    {
        [HiddenInput]
        public int id { get; set; }

        //[Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

       // [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
      
        public List<Drink> drinkList { get; set; }

        [Display(Name = "Total")]
        public double total { get; set; }
    }
}
