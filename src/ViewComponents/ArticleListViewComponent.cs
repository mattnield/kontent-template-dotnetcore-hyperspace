using Microsoft.AspNetCore.Mvc;
using src.Models;
using Kentico.Kontent.Delivery.Abstractions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Kentico.Kontent.Delivery.Urls.QueryParameters.Filters;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using System;

namespace src.ViewComponents
{
    public class ArticleListViewComponent : ViewComponent
    {
        private IDeliveryClient client;
        public ArticleListViewComponent(IDeliveryClient deliveryClient)
        {
            client = deliveryClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Article> articles){
            var hasArticles = await Task.Run(() => articles.Any());
            if(!hasArticles) return null;

            return View(articles);
        }
    }
}