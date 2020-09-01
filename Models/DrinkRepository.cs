using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class DrinkRepository : IDrinkRepository
    {
        private List<Drink> _drinkList;
       // public Order order;

        public DrinkRepository()
        {
            _drinkList = new List<Drink>()
            {
                new Drink {id = 1, drinkName="Cosmopoliton", drinkDescription="Vokda, triple sec, cranberry juice, and freshly squeezed lime juice", drinkPrice=6.05},
                new Drink {id = 2, drinkName="Bloody Mary", drinkDescription="Vodka, tomato juice, and lemon juice", drinkPrice=5.35 },
                new Drink {id = 3, drinkName="Tequila Sunrise", drinkDescription=" Tequila, orange juice, and grenadine syrup served unmixed in a tall glass", drinkPrice=7.49},
                new Drink {id = 4, drinkName="Sea Breeze", drinkDescription=" Vodka, cranberry juice, and grapefruit juice shaken", drinkPrice=6.58}
                
            };
        }

      /*  public Drink Add(Drink drink)
        {
            order.drinkList.Add(drink);

            return drink;
        }

        public Drink Delete(int id)
        {
            var toBeRemoved = _drinkList.FirstOrDefault((d => d.id == id));
            if(toBeRemoved != null)
            {
                _drinkList.Remove(toBeRemoved);
            }
            return toBeRemoved;
        }*/

        public IEnumerable<Drink> GetAllDrinks()
        {
            return _drinkList;
        }

        public Drink GetDrink(int id)
        {
            return _drinkList.FirstOrDefault(d => d.id == id);
        }
    }
}
