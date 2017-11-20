using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;

using Homework5.DAL;
using Homework5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework5.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}