using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface IOrderRepository
    {
        Order Add(Order order);

        Order Edit(Order orderChanges);

        Order Delete(int id);

        IEnumerable<Order> GetAllOrders();

        Order GetOrder(int id);

    }
}
