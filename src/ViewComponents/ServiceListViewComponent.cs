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
    public class ServiceListViewComponent : ViewComponent
    {
        private IDeliveryClient client;
        public ServiceListViewComponent(IDeliveryClient deliveryClient)
        {
            client = deliveryClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Service> services)
        {
            var hasServices = await Task.Run(() => services.Any());
            if(!hasServices) return null;

            return View(services);
        }
    }
}