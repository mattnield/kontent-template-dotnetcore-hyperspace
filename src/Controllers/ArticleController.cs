using System.Threading.Tasks;
using src.Models;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Kentico.Kontent.Delivery.Urls.QueryParameters.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace src.Controllers
{
    public class ArticleController : BaseController<HomeController>
    {
        public ArticleController(IDeliveryClient deliveryClient, ILogger<HomeController> logger) : base(deliveryClient, logger)
        {

        }

        public async Task<ActionResult> Detail(string slug)
        {
            var articles = await DeliveryClient.GetItemsAsync<Article>(
                new EqualsFilter($"elements.{Article.SlugCodename}", slug),
                new DepthParameter(0)
            );

            if(articles.Items.Count==0){
                return NotFound();
            }

            return View(articles.Items[0]);
        }
    }
}
