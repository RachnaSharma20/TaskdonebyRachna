using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EmployeeManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly string path = Path.Combine(Directory.GetCurrentDirectory(), "AppData", "User.json");

        //Model: Define and use models to pass data between controllers and backend(InMemory,Json file).

        public IActionResult Index()
        {
            var viewModel = new UserViewModel
            {
                Users = GetUsersFromJson()
            };
            ViewBag.Message = "User List Loaded Successfully";
            return View(viewModel);
        }

        //User Save with Json file and Use ViewData and with valitdation
        [HttpGet]
        public IActionResult UserSave()
        {
            UserModel model=new UserModel();
            var users = GetUsersFromJson();
            ViewData["users"] = users;
            return View(model);
        }

        [HttpPost]
        public IActionResult UserSave(UserModel model)
        {
            var users = GetUsersFromJson();
            if (ModelState.IsValid)
            {
                users.Add(model);
                SaveUsersToJson(users);
                ViewBag.Message = "User added successfully!";
                model.Email = "";
                model.Name = "";
                model.Password = "";
            }
            ViewData["users"] = users;

            return View(model);
        }

        // Read JSON File and Return List
        public List<UserModel> GetUsersFromJson()
        {
            if (!System.IO.File.Exists(path))
                return new List<UserModel>();

            var jsonData = System.IO.File.ReadAllText(path);
            return System.Text.Json.JsonSerializer.Deserialize<List<UserModel>>(jsonData) ?? new List<UserModel>();
        }

        // Save users to JSON file
        private void SaveUsersToJson(List<UserModel> users)
        {
            var jsonData = System.Text.Json.JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(path, jsonData);
        }

        [HttpGet]
        public IActionResult GetUserListWithAjax()
        {
            return View();
        }


        #region Httpcontext
        //  Save User Session Data
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("UserName", "Rachna sharma");
            HttpContext.Session.SetInt32("UserId", 101);
            return Content("Session Data Saved!");
        }

        //  Retrieve User Session Data
        public IActionResult GetSession()
        {
            string userName = HttpContext.Session.GetString("UserName") ?? "Guest";
            int? userId = HttpContext.Session.GetInt32("UserId");

            return Content($"User: {userName}, ID: {userId}");
        }

        // Save Cookie Data
        public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1) // Expires in 1 day
            };
            Response.Cookies.Append("UserEmail", "user@gmail.com", options);
            return Content("Cookie Saved!");
        }

        // Retrieve Cookie Data
        public IActionResult GetCookie()
        {
            string userEmail = Request.Cookies["UserEmail"] ?? "No Cookie Found";
            return Content($"User Email from Cookie: {userEmail}");
        }

        // Get User-Agent Header
        public IActionResult GetUserAgent()
        {
            string userAgent = HttpContext.Request.Headers["User-Agent"];
            return Content($"User-Agent: {userAgent}");
        }

        public IActionResult GetHttpcontext()
        {
            SetCookie();
            SetSession();
            return View();
        }
        #endregion

    }
}
