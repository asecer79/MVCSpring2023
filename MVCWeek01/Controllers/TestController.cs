using Microsoft.AspNetCore.Mvc;
using MVCWeek01.Models;

namespace MVCWeek01.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.AdiSoyadi = "Aydın SEÇER";

            var info = new MessageModel
            {
                MessageId = 3,
                Message = "This is model data"
            };
           


            return View(info);
        }


        public string WhoAreYou()
        {
            return "My name is Aydın";
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            return sum;
        }

        public JsonResult GetMessagesA()
        {
            List<MessageModel> messages = new List<MessageModel>();

            messages.Add(new MessageModel(){MessageId = 1,Message = "M1"});
            messages.Add(new MessageModel() { MessageId = 2, Message = "M2" });
            messages.Add(new MessageModel() { MessageId = 3, Message = "M3" });
            messages.Add(new MessageModel() { MessageId = 4, Message = "M4" });

            return Json(messages);
        }

        public List<MessageModel> GetMessagesB()
        {
            List<MessageModel> messages = new List<MessageModel>();

            messages.Add(new MessageModel() { MessageId = 1, Message = "M1" });
            messages.Add(new MessageModel() { MessageId = 2, Message = "M2" });
            messages.Add(new MessageModel() { MessageId = 3, Message = "M3" });
            messages.Add(new MessageModel() { MessageId = 4, Message = "M4" });

            return messages;
        }
    }
}
