using Microsoft.AspNetCore.Mvc;

public class RegistrationController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(UserRegistrationModel model)
    {

        ViewBag.WelcomeMessage = $"Welcome, {model.FirstName}!";
        return View("Result");
    }
}
