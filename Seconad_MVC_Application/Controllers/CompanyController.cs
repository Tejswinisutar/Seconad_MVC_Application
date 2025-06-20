using System;
using System.Collections.Generic;
using Seconad_MVC_Application.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seconad_MVC_Application.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Create()
        {
            CompanyModel model = new CompanyModel();
            model.Comp_Name = "Fork Infosystem";
            model.Remarks = "Good Company";
            model.Strength = 25;
            return View(model);
        }

        public ActionResult Edit(int? Id = 0 )
        {
            return View();
        }

        public ActionResult Delete(int? Id = 0)
        {
            return View();
        }

        public ActionResult Details(int? Id = 0)
        {
            return View();
        }
    }
}