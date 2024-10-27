using System.ComponentModel.DataAnnotations;

namespace DeliveryServiceSystem.Models
{
    public class Order
    {
        public int Id {  get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public DateTimeOffset DeliveryTime { get; set; }

        public int DistrictId {  get; set; }    

        public Order() { } 

        public Order (int id, string description, double weight, DateTime deliveryTime, int districtId)
        {
            Id = id;
            Description = description;
            Weight = weight;
            DeliveryTime = deliveryTime;
            DistrictId = districtId;
        }
    }
}
