using Microsoft.AspNetCore.Mvc;
using SoreSystem.Models;
using System.Collections.Generic;

namespace SoreSystem.Controllers
{
    public class HomeController : Controller
    {
       public List<Items> CreateListItems()
        {
            List<Items> LstItems = new List<Items>();
            Items oItems = new Items();
            oItems.ItemId = 1;
            oItems.ItemName = "Hp zbook g3";
            oItems.SalesPrice = 7500;
            oItems.PurchasePice = 6500;
            LstItems.Add(oItems);

            oItems = new Items();
            oItems.ItemId = 2;
            oItems.ItemName = "Hp zbook g2";
            oItems.SalesPrice = 12500;
            oItems.PurchasePice = 11500;
            LstItems.Add(oItems);

            oItems = new Items();
            oItems.ItemId = 3;
            oItems.ItemName = " dell 7510";
            oItems.SalesPrice = 10500;S
            oItems.PurchasePice = 9000;
            LstItems.Add(oItems);

            oItems = new Items();
            oItems.ItemId = 4;
            oItems.ItemName = "dell vestro ";
            oItems.SalesPrice = 8000;
            oItems.PurchasePice = 6500;
            LstItems.Add(oItems);
            return LstItems;
        }

        public IActionResult Index()
        {
            ViewBag.pageTitle = "Buy a new Item from here";
            List<Items> LstItems = new List<Items>();
            Items oItems = new Items();
            oItems.ItemId = 1;
            oItems.ItemName = "Hp zbook g3";
            oItems.SalesPrice = 7500;
            oItems.PurchasePice = 6500;
            LstItems.Add(oItems);   
            return View(CreateListItems());
        }


    }
}
