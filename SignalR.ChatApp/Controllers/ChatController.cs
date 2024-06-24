using Microsoft.AspNetCore.Mvc;

namespace SignalR.ChatApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
