namespace DeliveryService.Models
{
    public class Order
    {
        public int Id;
        public string Description;
        public double Weight;

        public DateTime DeliveryTime;

        public District DistrictId;    

        public Order (int id, string description, double weight, DateTime deliveryTime, District districtId)
        {
            Id = id;
            Description = description;
            Weight = weight;
            DeliveryTime = deliveryTime;
            DistrictId = districtId;
        }
    }
}
