using System;
using Microsoft.AspNetCore.Mvc;
using SampleMediatr.Web.ViewModels;
using Samples.Business;

namespace SampleMediatr.Web.Controllers
{
    public class LogController : Controller
    {
        public LogController(IMessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        private readonly IMessageStore _messageStore;

        public IActionResult Index()
        {
            return View(new MessageViewModel() { Messages = _messageStore.Messages });
        }
    }
}
