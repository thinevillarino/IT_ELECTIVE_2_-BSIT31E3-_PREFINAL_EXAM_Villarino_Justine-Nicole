using Microsoft.AspNetCore.Mvc;
using PrefinalExam.Models;

namespace PrefinalExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<ExamQuestion> questions = new List<ExamQuestion>();

            return View(questions);
        }
    }
}