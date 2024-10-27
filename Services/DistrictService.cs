using DeliveryServiceSystem.Models;
using System.Text.Json;

namespace DeliveryServiceSystem.Services
{
    public class DistrictService
    {
        public List<District> LoadDistricts(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<District>>(json);
        }
    }
}
