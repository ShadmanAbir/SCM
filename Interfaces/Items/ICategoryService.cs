using SCM.Model.Items;

namespace SCM.Interfaces.Item
{
    public interface ICategoryService
    {
        public List<CategoryViewModel> GetAllCategory();
        public CategoryViewModel GetCategoryByID(int ID);
        public bool AddCategory(CategoryViewModel categoryVM);
        public bool Updatetem(CategoryViewModel categoryVM);
        public bool RemoveCategory(CategoryViewModel categoryVM);
    }
}
