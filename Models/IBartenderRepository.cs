using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IBartenderRepository
    {
        Bartender GetDrink(int id);

        IEnumerable<Bartender> AllGetBartenders();

      /*  Drink Add(Drink drink);

        Drink Delete(int id);*/
    }
}
