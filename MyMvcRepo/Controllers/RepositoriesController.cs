using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcRepo.Controllers
{
    public class RepositoriesController : Controller
    {
        
        // GET: Repositories
        public ActionResult Index()
        {
            return View("Index");
        }

        //save in session the the repository's names the user searched.
        public string addSearchToSession(string searchName)
        {
            var searchObjects = (Session["search"] as List<string>) ?? new List<string>();
            searchObjects.Add(searchName);
            Session["search"] = searchObjects;
            return JsonConvert.SerializeObject(searchObjects.ToArray());
        }




    }
}