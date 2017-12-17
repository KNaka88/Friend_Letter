using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/hello")]
      public ActionResult Hello()
      {
        return View();
      }

      [Route("/goodbye")]
      public string Goodbye() { return "Goodbye friend."; }

      [Route("/")]
      public ActionResult Letter()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Jessica");
        myLetterVariable.SetSender("John");
        return View(myLetterVariable);
      }

      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }
    }
}
