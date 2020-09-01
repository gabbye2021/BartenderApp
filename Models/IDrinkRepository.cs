using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IDrinkRepository
    {
        Drink GetDrink(int id);

        IEnumerable<Drink> GetAllDrinks();

      /*  Drink Add(Drink drink);

        Drink Delete(int id);*/
    }
}
