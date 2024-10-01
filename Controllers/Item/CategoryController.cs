using Microsoft.AspNetCore.Mvc;
using SCM.Interfaces.Item;
using SCM.Interfaces.Items;
using SCM.Model.Items;
using SCM.ViewModel.Items;
namespace SCM.Controllers.Item
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<CategoryViewModel>>> Get()
        {
            return Ok(await _categoryService.GetAllCategory());
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryViewModel>> Get(int id)
        {
            return Ok(await _categoryService.GetCategoryByID(id));
        }

        
        [HttpPost]
        public async Task<ActionResult<bool>> Post(CategoryViewModel categoryVM)
        {
            return Ok(await _categoryService.AddCategory(categoryVM));
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, CategoryViewModel categoryVM)
        {
            return Ok(await _categoryService.UpdateCategory(id, categoryVM));
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok(await _categoryService.RemoveCategory(id));
        }
    }
}
