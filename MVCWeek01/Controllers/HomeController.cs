using Microsoft.AspNetCore.Mvc;
using MVCWeek01.Models;

namespace MVCWeek01.Controllers
{

    //hostAddress/controller/action
    public class HomeController : Controller
    {
        public IActionResult Index() //action //method
        {
            MessageModel messageModel = new MessageModel();
            messageModel.MessageId = 1;
            messageModel.Message = "Hello world";


            return View(messageModel);  //view page result page
        }


        public IActionResult About()
        {

            MessageModel messageModel = new MessageModel();
            messageModel.MessageId = 1;
            messageModel.Message = "I am about page";



            return View(messageModel);  //view page result page
        }
    }
}
