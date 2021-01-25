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
    public class OrderController : ControllerBase
    {
        public static List<Cart> cart = new List<Cart>
        {
            new Cart{Id=1,userId=1,menuItemId=1,menuItemName="Pizza"},
            new Cart{Id=1,userId=2,menuItemId=2,menuItemName="Pasta"}
        };
        [HttpGet]
        public ActionResult<IEnumerable<Cart>> GetCartItems()
        {
            return cart;
        }

        [HttpGet("{id}")]
        public ActionResult<Cart> GetItems(int menuItemId)
        {
            var mItem = cart.FirstOrDefault(item => item.Id == menuItemId);

            if (mItem == null)
            {
                return NotFound();
            }

            return mItem;
        }
    }
}
