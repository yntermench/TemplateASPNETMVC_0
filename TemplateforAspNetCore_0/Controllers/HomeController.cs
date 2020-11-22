﻿using Microsoft.AspNetCore.Mvc;
using TemplateforAspNetCore_0.Domain;

namespace TemplateforAspNetCore_0.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;


        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}