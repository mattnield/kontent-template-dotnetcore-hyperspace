using System.Threading.Tasks;
using src.Models;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace src.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        public HomeController(IDeliveryClient deliveryClient, ILogger<HomeController> logger) : base(deliveryClient, logger)
        {

        }

        public async Task<ViewResult> Index()
        {
            var homepage = await DeliveryClient.GetItemAsync<Home>("home");

            return View(homepage.Item);
        }
    }
}
