using Microsoft.AspNetCore.Mvc;
using SCM.Interfaces.Item;
using SCM.Model.Items;

namespace SCM.Controllers.Item
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IIteamBaseService _iteamBaseService;
        public ItemController(IIteamBaseService iteamBaseService)
        {
            _iteamBaseService = iteamBaseService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemBaseViewModel>>> Get()
        {
            return await _iteamBaseService.GetAllItem();
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
