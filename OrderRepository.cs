using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBaker
{
    public class OrderRepository
    {
        private List<Order> _orders = new List<Order>();

        public bool AddOrderToOrders(Order order)
        {
            int initial = _orders.Count();
            _orders.Add(order);
            return _orders.Count() > initial; 
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        public Order GetAnOrderByNumber(int num)
        {
            return _orders.SingleOrDefault(o => o.OrderNumber == num);
        }

        public bool UpdateOrder(int num, Order updatedOrder)
        {
            Order originalOrder = GetAnOrderByNumber(num);

            if (originalOrder != null)
            {
                originalOrder.OrderNumber = updatedOrder.OrderNumber;
                originalOrder.NumberOfBatches = updatedOrder.NumberOfBatches;
                originalOrder.Product = updatedOrder.Product;
                return true;
            }
            else
                return false;
        }

        public bool DeleteOrder(int orderToDelete)
        {
            return _orders.Remove(GetAnOrderByNumber(orderToDelete));
        }

    }
}
