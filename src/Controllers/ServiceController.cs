using System.Threading.Tasks;
using src.Models;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace src.Controllers
{
    public class ServiceController : BaseController<ServiceController>
    {
        public ServiceController(IDeliveryClient deliveryClient, ILogger<ServiceController> logger) : base(deliveryClient, logger)
        {

        }

        public async Task<ViewResult> Index()
        {
            var services = await DeliveryClient.GetItemsAsync<Service>(
                new DepthParameter(0),
                new OrderParameter("elements.name")
            );

            return View(services.Items);
        }
    }
}