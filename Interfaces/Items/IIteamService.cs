using SCM.Model.Items;

namespace SCM.Interfaces.Item
{
    public interface IItemService
    {
        public Task<List<ItemViewModel?>> GetAllItem();
        public Task<ItemViewModel?> GetItemByID(int ID);
        public ValueTask<bool> AddItem(ItemViewModel itemVM);
        public ValueTask<bool> RemoveItem(int id);
        public ValueTask<bool> Updatetem(int id, ItemViewModel itemVM);

    }
}
