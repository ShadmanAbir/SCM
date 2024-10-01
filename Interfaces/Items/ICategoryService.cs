using SCM.ViewModel.Items;

namespace SCM.Interfaces.Items
{
    public interface ICategoryService
    {
        public Task<List<CategoryViewModel>> GetAllCategory();
        public Task<CategoryViewModel> GetCategoryByID(int ID);
        public ValueTask<bool> AddCategory(CategoryViewModel categoryVM);
        public ValueTask<bool> UpdateCategory(int id,CategoryViewModel categoryVM);
        public ValueTask<bool> RemoveCategory(int id);
    }
}
