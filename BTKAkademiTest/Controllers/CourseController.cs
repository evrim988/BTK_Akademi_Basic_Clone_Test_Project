using BTKAkademiTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTKAkademiTest.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Candidates;
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register([FromForm]Candidate model)
        {
            if (Repository.Candidates.Any(s => s.Email == model.Email))
                ModelState.AddModelError("", "Bu Email Adresine Ait Bir Kayıt Bulunmaktadır.");

            if(ModelState.IsValid)
            {
                Repository.Add(model);
                return View("FeedBack", model);
            }
            return View();
        }

      
    }
}
