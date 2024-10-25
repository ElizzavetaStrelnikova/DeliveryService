namespace DeliveryService.Models
{
    public class District
    {
        public int Id;
        public string Name;
        public List<Order> Orders { get; set; }

        public District(int id, string name)
        {
            Id = id;
            Name = name;
            Orders = new List<Order>(); 
        }

        public List<Order> GetOrders(int districtId)
        {
            return Orders.Where(order => order.DistrictId.Id == districtId).ToList();
        }

        public void AddOrder(Order order)
        {
            if (order.DistrictId.Id == this.Id)
            {
                Orders.Add(order);
            }
            else
            {
                throw new ArgumentException("Заказ принадлежит другому району.");
            }
        }
    }
}

