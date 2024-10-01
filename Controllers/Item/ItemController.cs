using Microsoft.AspNetCore.Mvc;
using SCM.Interfaces.Item;
using SCM.Model.Items;

namespace SCM.Controllers.Item
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemViewModel>>> Get()
        {
            return await _itemService.GetAllItem();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemViewModel>> Get(int id)
        {
            return await _itemService.GetItemByID(id);
        }

        
        [HttpPost]
        public async Task<ActionResult<bool>> Post(ItemViewModel itemVM)
        {
            return Ok(await _itemService.AddItem(itemVM));
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, ItemViewModel itemVM)
        {
            return Ok(await _itemService.Updatetem(id, itemVM));
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
