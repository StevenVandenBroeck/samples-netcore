using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleMediatr.Web.Eventing;
using Samples.ViewModels;

namespace Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        private readonly IMediator _mediator;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Car car)
        {
            //_mediator.Send(new CarRequest() { Brand = car.Brand, Model = car.Model, Color = car.Color });

            _mediator.Publish(new CarNotification() { Brand = car.Brand, Model = car.Model, Color = car.Color });

            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
