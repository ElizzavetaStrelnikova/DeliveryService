using System.ComponentModel.DataAnnotations;

namespace DeliveryServiceSystem.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public District() { } 

        public District(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

