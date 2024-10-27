namespace DeliveryServiceSystem.Models
{
    public static class Validation
    {
        public static bool ValidateOrder(Order order)
        {
            return order != null && order.Weight > 0 && !string.IsNullOrWhiteSpace(order.Description);
        }
    }
}
