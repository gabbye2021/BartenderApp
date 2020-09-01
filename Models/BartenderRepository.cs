using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class BartenderRepository : IBartenderRepository
    {
        private List<Bartender> _bartenderList;
       // public Order order;

        public BartenderRepository()
        {
            _bartenderList = new List<Bartender>()
            {
                new Bartender {id = 1, name="James Jones", username="jjones064", password="helloworld"},
                new Bartender {id = 2, name="Kim Hart", username="khart09", password="drink$"}
            };
        }

        public IEnumerable<Bartender> AllGetBartenders()
        {
            return _bartenderList;
        }



        Bartender IBartenderRepository.GetDrink(int id)
        {
            return _bartenderList.FirstOrDefault(b => b.id == id);

        }
    }
}
