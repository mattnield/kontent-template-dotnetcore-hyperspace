using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    public class ErrorController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("/Error/{statusCode}")]
        public ViewResult Status(int statusCode)
        {
            ViewResult view;
            switch (statusCode)
            {
                case StatusCodes.Status404NotFound:
                    view = View("~/Views/Error/NotFound.cshtml");
                    break;
                default:
                    view = View("~/Views/Error/GeneralError.cshtml");
                    break;
            }

            Response.StatusCode = 200;
            return view;
        }
    }
}
