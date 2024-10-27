using DeliveryServiceSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryServiceSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryServiceController : ControllerBase
    {
        private readonly Services.DeliveryService deliveryService;

        public DeliveryServiceController(Services.DeliveryService deliveryService)
        {
            this.deliveryService = deliveryService ?? throw new ArgumentNullException(nameof(deliveryService));
        }

        [HttpGet("filter")]
        public ActionResult<List<Order>> FilterOrders(string districtName, DateTime startTime)
        {
            try
            {
                var orders = deliveryService.FilterOrders(districtName, startTime);
                return Ok(orders);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
