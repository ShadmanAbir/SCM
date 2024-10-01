using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SCM.Interfaces.Item;
using SCM.Model;
using SCM.Model.Items;

namespace SCM.Services.Items
{
    public class ItemService : IItemService
    {
        private readonly SCMContext _scmContext;
        private readonly IMapper _mapper;

        public ItemService(SCMContext scmContext,IMapper mapper)
        {
            _scmContext = scmContext;
            _mapper = mapper;
        }
        public ValueTask<bool> AddItem(ItemViewModel itemVM)
        {
            
             _scmContext.Item.AddAsync(_mapper.Map<Item>(itemVM));
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public Task<List<ItemViewModel?>> GetAllItem()
        {
            return  _mapper.ProjectTo<ItemViewModel?>(_scmContext.Item).ToListAsync();
        }

        public Task<ItemViewModel?> GetItemByID(int ID)
        {
           return _scmContext.Item
        .SingleOrDefaultAsync(a => a.ItemID == ID && a.IsDeleted == false)
        .ContinueWith(task =>
        {
            var item = task.Result;

            if (item == null)
            {
                throw new FileNotFoundException();
            }

            // Map the entity to a ViewModel using AutoMapper
            return _mapper.Map<ItemViewModel?>(item);
        });
        }

        public  ValueTask<bool> RemoveItem(int id)
        {
            var data =  _scmContext.Item.SingleOrDefault(a => a.ItemID == id);
            data.IsDeleted = true;
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public ValueTask<bool> Updatetem(int id,ItemViewModel itemVM)
        {
            var data = _scmContext.Item.SingleOrDefault(a => a.ItemID == id);
            data.ItemName = itemVM.ItemName;
            data.CategoryID = itemVM.CategoryID;
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }
    }
}
