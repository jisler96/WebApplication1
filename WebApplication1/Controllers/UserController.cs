using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var userModel = new UserModel();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            int userId = user.Id;
            string firstName = user.FirstName;
            string lastName = user.LastName;
            byte age = user.Age;
            DateTime registeredDate = user.RegisterDate;
            ViewData["Id"] = userId;
            ViewData["FirstName"] = firstName;
            ViewData["LastName"] = lastName;
            ViewData["Age"] = age;
            ViewData["RegisteredDate"] = registeredDate;


            return View() ;
        }

        public string TestMethod(string firstName, string lastName)
        {
            string testMessage = $"This is the TestMethod return value, FirstName: {firstName}, LastName: {lastName}";
            ViewData["TestMessage"] = testMessage;
            return testMessage; 
        }


        
    }
}