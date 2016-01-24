using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;
using System.Text;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            List<SelectListItem> listSelectListItem = new List<SelectListItem>();

            foreach (City city in db.Cities)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = city.Name,
                    Value = city.ID.ToString(),
                    Selected = city.IsSelected
                };

                listSelectListItem.Add(selectListItem);
            }
            CitiesViewModel citiesViewModel = new CitiesViewModel();
            citiesViewModel.Cities = listSelectListItem;

            return View(citiesViewModel);
        }

        [HttpPost]
        public string Index(IEnumerable<string> selectedCities)
        {
            if(selectedCities == null)
            {
                return "You did not select any city";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You Seleceted - " + string.Join(",", selectedCities));
                return sb.ToString();
            }

        }
    }
}