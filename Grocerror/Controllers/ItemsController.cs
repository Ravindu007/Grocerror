using Grocerror.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grocerror.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        private ItemService _itemService;

        public ItemsController()
        {
            _itemService = new ItemService();
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var allItems = _itemService.AllItems();
            return Ok(allItems);
        }
    }
}
