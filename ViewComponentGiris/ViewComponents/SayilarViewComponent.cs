using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentGiris.ViewComponents
{
    public class SayilarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int minNumber, int maxNumber)
        {
            List<int> sayilar = Enumerable.Range(minNumber, maxNumber - minNumber + 1).ToList();
            
            return View(sayilar);
        }
    }
}
