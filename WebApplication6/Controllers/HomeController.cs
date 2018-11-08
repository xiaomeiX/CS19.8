using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
//using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;


namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public static List<HomeModel> UserList = new List<HomeModel>();
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
       // [AcceptVerbs(HttpVerbs.Post)]
        //[RequireHttps()]
        [HttpPost]
        public ActionResult Index([Bind(Include =
            "Id," +
            "LastName," +
            "FirstName"+
            "")] HomeModel user)
        {
            //var model = new List<HomeModel>();
          

            if (!ModelState.IsValid)
            {
                return View(user);
            }
            HomeModel userObj = new HomeModel
            {
                Id = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName
            };
            return View(userObj);
        }
        // GET:/server/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //FormCollection form
        public ActionResult Create(HomeModel user) {
           // var Id = form["Id"];
          //  var LastName = form["LastName"].ToString();
          //  var FirstName = form["FirstName"].ToString();
            ViewBag.Id = user.Id;
            ViewBag.LastName = user.LastName;
            ViewBag.FirstName = user.FirstName;
            
          
                if (ModelState.IsValid)
                {
                    UserList.Add(user);
                    return RedirectToAction("Index");
                }
           
                return View();  
               
        }

        public ActionResult Welcome(HomeModel user)
        {
            ViewData["Message"] = "User Id " + user.Id + "\n" + user.LastName +" "+ user.FirstName;
            ViewData["Id"] = user.Id;
            ViewData["LastName"] = user.LastName;
            ViewData["FirstName"] = user.FirstName;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            int? Id = (int?)TempData["Id"];
            TempData.Keep();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}