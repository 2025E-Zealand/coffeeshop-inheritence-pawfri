using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60;

public class Order
{
    public int OrderId { get; set; }
    public string Barista {  get; set; }
    public string Customer { get; set; }
    public int TableId { get; set; }
    public int TakeAway { get; set; }
    List<Order> Orders { get; set; } = new List<Order>();

    public Order(int orderId, string barista, string customer, int tableId, int takeAway, List<Order> orders)
    {
        OrderId = orderId;
        Barista = barista;
        Customer = customer;
        TableId = tableId;
        TakeAway = takeAway;
        Orders = orders;
    }

    public void TotalPrice()
    {
        int totalPrice = 0;

        foreach (var order in Orders)
        {
           
        }
    }
}
