using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> _orderList;
       
        
        public OrderRepository()
        {
            _orderList = new List<Order>()
            {
                new Order {id=1, FirstName="John", LastName="Fincher"}
            };

        }
        public Order Add(Order order)
        {
            order.id = _orderList.Max(o => o.id) + 1;
            _orderList.Add(order);
            return order;

        }

        public Order Delete(int id)
        {
            var toBeRemoved = _orderList.FirstOrDefault(o => o.id == id);
            if (toBeRemoved != null)
            {
                _orderList.Remove(toBeRemoved);
            }
            return toBeRemoved;
        }

        public Order Edit(Order orderChanges)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderList;
        }

        public Order GetOrder(int id)
        {
            return _orderList.FirstOrDefault(o => o.id == id);
        }
    }
}
