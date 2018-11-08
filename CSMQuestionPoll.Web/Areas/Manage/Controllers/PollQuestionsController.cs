using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSMQuestionPoll.Web.Areas.Manage.Controllers
{
    public class PollQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}