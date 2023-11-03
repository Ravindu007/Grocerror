using Grocerror.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grocerror.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        private IItemRepository _itemService;

        public ItemsController(IItemRepository repository)
        {
            _itemService = repository;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var allItems = _itemService.AllItems();
            return Ok(allItems);
        }
    }
}
