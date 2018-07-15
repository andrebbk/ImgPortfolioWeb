﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPortefolio.Data;

namespace WebAppPortefolio.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly PortefolioContext db;

        public SidebarViewComponent(PortefolioContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke(
        int maxPriority, bool isDone)
        {
            return View();
        }
    }
}
