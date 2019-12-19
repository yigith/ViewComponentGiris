using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentGiris.Models;

namespace ViewComponentGiris.ViewComponents
{
    // ayrıntılı bilgi: https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-2.2
    public class CategoriesListViewComponent : ViewComponent
    {
        private readonly Database db;
        public CategoriesListViewComponent(Database database)
        {
            db = database;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.GetCategories());
        }
    }
}
