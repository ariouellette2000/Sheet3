using Entities;
using ExampleMemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMemo.Controllers
{
    public class HomeController : Controller
    {
        //Link between model and controller
        //You first have to feel up the model
        public Model myModel = new Model();
        // GET: Home
        public ActionResult Index()
        {
            var records = myModel.GetList();
            return View(records);
        }

        //Open a new page. naming it create you will be able to create a view with all the infos already in it
       public ActionResult Create()
        {
            return View();
        }

        public ActionResult Remove(int id)
        {
            myModel.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var records = myModel.getMemo(id);
            return View(records);
        }

        public ActionResult Details(int id)
        {
            var records = myModel.getMemo(id);
            return View(records);
        }


        [HttpPost]
        public ActionResult Create(Memo m)
        {
            //Insert the object
            myModel.Insert(m);
            //Come back to the main page
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Memo item)
        {
            myModel.Edit(item);
            return RedirectToAction("Index");
        }
    }
}