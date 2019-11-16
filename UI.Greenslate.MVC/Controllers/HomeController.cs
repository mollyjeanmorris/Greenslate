using DATA.Greenslate.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Greenslate.MVC.ViewModels;
using UI.Greenslate.MVC.Controllers;

namespace UI.Greenslate.MVC.Controllers
{
    public class HomeController : Controller
    {
        private GreenslateEntities db = new GreenslateEntities();

        public ActionResult Index(){

            ProjectsByUserViewModel pbuVM = new ProjectsByUserViewModel();
            ProjectsByUserController pbuC = new ProjectsByUserController();

            pbuVM.ProjectsByUser = pbuC.LoadListProjectsForAllUsers();
            pbuVM.Users = db.Users.ToList();
            return View(pbuVM);
        }
    }
}