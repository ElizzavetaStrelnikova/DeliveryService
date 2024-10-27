using DeliveryServiceSystem.Models;

namespace DeliveryServiceSystem.Services
{
    public class DeliveryService
    {
        private List<District> districts;
        private List<Order> orders;

        public DeliveryService(List<District> districts, List<Order> orders)
        {
            this.districts = districts;
            this.orders = orders;
        }

        public List<Order> FilterOrders(string districtName, DateTime startTime)
        {
            if (string.IsNullOrWhiteSpace(districtName))
            {
                throw new ArgumentException("Название района не может быть пустым.", nameof(districtName));
            }

            var district = districts.FirstOrDefault(d => d.Name.Equals(districtName, StringComparison.OrdinalIgnoreCase));
            if (district == null)
            {
                throw new ArgumentException($"Район '{districtName}' не найден.");
            }

            var endTime = startTime.AddMinutes(30);

            var filteredOrders = orders
                .Where(order => order.DistrictId == district.Id &&
                       order.DeliveryTime >= startTime &&
                       order.DeliveryTime <= endTime)
                .ToList();

            if (!filteredOrders.Any())
            {
                throw new InvalidOperationException("Нет заказов, соответствующих заданным критериям.");
            }

            return filteredOrders;
        }
    }
}
