using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<JobOpening> allJobOpenings = JobOpening.GetAll();
            return View(allJobOpenings);
        }

        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/jobs")]
        public ActionResult Create()
        {
            string newJobTitle = Request.Form["title"];
            string newJobDescription = Request.Form["description"];
            string newJobContact = Request.Form["contact"];

            JobOpening newJobOpening = new JobOpening(newJobTitle, newJobDescription, newJobContact);
            newJobOpening.Save();
            List<JobOpening> allJobs = JobOpening.GetAll();
            return View("Index", allJobs);
        }

        [HttpPost("/jobs/delete")]
        public ActionResult DeleteAll()
        {
            JobOpening.ClearAll();
            return View();
        }

    }


}
