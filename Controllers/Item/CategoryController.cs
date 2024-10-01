using Microsoft.AspNetCore.Mvc;
using SCM.Interfaces.Item;
using SCM.Model.Items;
namespace SCM.Controllers.Item
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IItemService _itemService;
        public CategoryController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<ActionResult<IList<CategoryViewModel>>> Get()
        {
            return Ok(await _itemService.GetAllItem());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryViewModel>> Get(int id)
        {
            return null;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
