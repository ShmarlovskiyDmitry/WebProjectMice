using MICE.Domain.Abstract;
using MICE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MICE.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repositoryUser;
        private INewsRepository repositoryNews;

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public AdminController(IUserRepository uRepos,INewsRepository nRepos)
        {
            repositoryUser = uRepos;
            repositoryNews = nRepos;
        }

        public ViewResult UserList()
        {
            return View(repositoryUser.Users);
        }

        public ViewResult NewsList()
        {
            return View(repositoryNews.NewsContent);
        }



        [HttpGet]
        public ActionResult RegisterUser()
        {
            User newUser = new User();
            return View(newUser);
        }

        [HttpPost]
        public ActionResult RegisterUser(User user)
        {
            if(ModelState.IsValid)
            {
                repositoryUser.SaveUser(user);
                return RedirectToAction("UserList");
            }
            return View(user);
        }
       
        public ActionResult InfoUser(int Id)
        {
            User user = repositoryUser.Users.FirstOrDefault(u => u.ID == Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            User user =
                repositoryUser.Users.FirstOrDefault(u=>u.ID==Id);
            if (user != null)
            {
                repositoryUser.DeleteUser(user);

            }
            return RedirectToAction("UserList");
        }
        
    }
}