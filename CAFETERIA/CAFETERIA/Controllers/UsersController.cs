using CAFETERIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;


namespace CAFETERIA.Controllers
{
    public class UsersController : Controller
    {
        readonly ApplicationDbContext db = new ApplicationDbContext();
         
        // GET: Users
        public ActionResult ViewProfile()
        {
            var id = User.Identity.GetUserId();
            var users = db.Users.Find(id);
            return View(users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5

        [HttpPost]
        public ActionResult EditProfile(HttpPostedFileBase Picture)
        {
            if(Picture!=null)
            {
                string nombreArchivo = System.IO.Path.GetFileName(Picture.FileName);
                string filePath = "~/Content/Catalogo/" + User.Identity.GetUserName() + nombreArchivo;
                Picture.SaveAs(Server.MapPath(filePath));

                var id = User.Identity.GetUserId();
                var userdb = db.Users.Find(id);
                userdb.Picture = User.Identity.GetUserName() + nombreArchivo;
                db.Entry(userdb).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("ViewProfile", "Users");
        }
       
    }
}
