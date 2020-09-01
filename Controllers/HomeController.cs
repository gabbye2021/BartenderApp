using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BartenderApp.Models;
using Microsoft.AspNetCore.Razor.Language;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IDrinkRepository _drinkRepository;

        private readonly IOrderRepository _orderRepository;

        private readonly IBartenderRepository _bartenderRepository;

       
        public HomeController(ILogger<HomeController> logger, IDrinkRepository drinkRepository, IOrderRepository orderRepository, IBartenderRepository bartenderRepository)
        {
            _logger = logger;
            _drinkRepository = drinkRepository;
            _orderRepository = orderRepository;
            _bartenderRepository = bartenderRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            IEnumerable<Drink> dList = _drinkRepository.GetAllDrinks();
            ViewData.Model = dList;
            return View();
        }
        public IActionResult ThankYou()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult OrderConfirmation()
        {
            return View();
        }

        public IActionResult OrderQueue()
        {
            IEnumerable<Order> oList = _orderRepository.GetAllOrders();
            ViewData.Model = oList;
            return View();
        }

     /*   [HttpPost]
        public RedirectToActionResult Direction(string submit)
        {

            if(submit == "Menu")
            {
                return RedirectToAction("Menu");
            }
            if(submit == "Bartender")
            {
                return RedirectToAction("OrderQueue");
            }
            return RedirectToAction("Menu");

        }*/
        //Not finished with this method. Look at logic on paper....might need to be adjusted
       /* [HttpPost]
        public ActionResult addToOrder(IEnumerable<Drink> list)
        {
            List<Drink> drinkOrders = new List<Drink>();
            double total = 0;
            double price = 0;
            Order order = new Order(); 
            foreach (var item in list)
            {
                if(item.quantity > 0)
                {
                    drinkOrders.Add(item);
                    price = item.drinkPrice * item.quantity;
                    total = total + price;

                }
            }
            order.drinkList = drinkOrders;
            order.total = total;
            if(order.total == 0)
            {
                TempData["error"] = "Please add a quantity to the drinks you would like to order.";
                IEnumerable<Drink> dList = _drinkRepository.GetAllDrinks();
                ViewData.Model = dList;
                return View("Menu");
            }
            else
            {
                ViewData.Model = order;
                return View("OrderConfirmation");
                
            }
        }*/

        [HttpGet]
        public ActionResult addToOrder(int id)
        {
         
            Drink drinkToAdd = _drinkRepository.GetDrink(id);
            List<Drink> dList = new List<Drink>();
            dList.Add(drinkToAdd);
            Order order = new Order();
            order.drinkList = dList;
            order.total = drinkToAdd.drinkPrice;
            ViewData.Model = order;
            return View("OrderConfirmation");

        }

        [HttpGet]
        public ActionResult LoginAttempt(Bartender user)
        {
            IEnumerable<Bartender> bList = _bartenderRepository.AllGetBartenders();
            foreach(var bartender in bList)
            {
                if(user.username == bartender.username)
                {
                    if(user.password == bartender.password)
                    {
                        return View("OrderQueue");
                    }
                    else
                    {
                        TempData["error"] = "Your username and password are incorrect. Please try logging in again.";
                    }
                }
               
            }
            TempData["error"] = "Your username and password are incorrect. Please try logging in again.";
            return View("Login");

        }

        [HttpGet]
        public ActionResult confirmedOrder(Order order, int drinkID)
        {
           

            int lik = drinkID;
            Drink drinkToAdd = _drinkRepository.GetDrink(drinkID);
            List<Drink> dList = new List<Drink>();
            dList.Add(drinkToAdd);
            order.drinkList = dList;
            _orderRepository.Add(order);
            return View("ThankYou");
        }

     
        public RedirectToActionResult Delete(int id)
        {
            _orderRepository.Delete(id);
            return RedirectToAction("OrderQueue");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
