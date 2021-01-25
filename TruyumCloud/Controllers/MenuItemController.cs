using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Truyum.Models;

namespace Truyum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {

        public static List<MenuItem> menuItems = new List<MenuItem>
        {
            new MenuItem{ItemId = 1, ItemName = "Pizza", Price = 50, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-10"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 2, ItemName = "Burger", Price = 35, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 3, ItemName = "Pasta", Price = 60, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"},
            new MenuItem{ItemId = 4, ItemName = "Maggie", Price = 30, Active = true, dateOfLaunch = Convert.ToDateTime("2020-05-15"), FreeDelivery = "yes"}
        };
       
        [HttpGet]
        public ActionResult<IEnumerable<MenuItem>> GetMenuItems()
        {
            return menuItems;
        }

        [HttpGet("{id}")]
        public ActionResult<MenuItem> GetItems(int id)
        {
            var mItem = menuItems.FirstOrDefault(item => item.ItemId == id);

            if (mItem == null)
            {
                return NotFound();
            }

            return mItem;
        }
    }
}
