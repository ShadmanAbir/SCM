using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SCM.Interfaces.Items;
using SCM.Model;
using SCM.Model.Items;
using SCM.ViewModel.Items;

namespace SCM.Services.Categorys
{
    public class CategoryService : ICategoryService
    {
        private readonly SCMContext _scmContext;
        private readonly IMapper _mapper;
        public CategoryService(SCMContext scmContext,IMapper mapper)
        {
            _scmContext = scmContext;
            _mapper = mapper;
        }
       /* public bool AddCategory(CategoryViewModel categoryVM)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel GetCategoryByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCategory(CategoryViewModel categoryVM)
        {
            throw new NotImplementedException();
        }

        public bool Updatetem(CategoryViewModel categoryVM)
        {
            throw new NotImplementedException();
        }*/

        public ValueTask<bool> AddCategory(CategoryViewModel itemVM)
        {

            _scmContext.Category.AddAsync(_mapper.Map<Category>(itemVM));
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public Task<List<CategoryViewModel?>> GetAllCategory()
        {
            return _mapper.ProjectTo<CategoryViewModel?>(_scmContext.Category).ToListAsync();
        }

        public Task<CategoryViewModel?> GetCategoryByID(int ID)
        {
            return _scmContext.Category
         .SingleOrDefaultAsync(a => a.CategoryID == ID && a.IsDeleted == false)
         .ContinueWith(task =>
         {
             var item = task.Result;

             if (item == null)
             {
                 throw new FileNotFoundException();
             }

             // Map the entity to a ViewModel using AutoMapper
             return _mapper.Map<CategoryViewModel?>(item);
         });
        }

        public ValueTask<bool> RemoveCategory(int id)
        {
            var data = _scmContext.Category.SingleOrDefault(a => a.CategoryID == id);
            data.IsDeleted = true;
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public ValueTask<bool> Updatetem(int id, CategoryViewModel itemVM)
        {
            var data = _scmContext.Category.SingleOrDefault(a => a.CategoryID == id);
            data.CategoryName = itemVM.CategoryName;
            data.CategoryID = itemVM.CategoryID;
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }
    }
}
