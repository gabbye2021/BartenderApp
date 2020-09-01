using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class Bartender
    {
        [HiddenInput]
        public int id { get; set; }

        public string name { get; set; }

        [Display(Name = "Username")]
        public string username { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

    }
}
