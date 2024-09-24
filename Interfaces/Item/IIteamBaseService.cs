using SCM.Model.Items;

namespace SCM.Interfaces.Item
{
    public interface IIteamBaseService
    {
        public Task<List<ItemBaseViewModel>> GetAllItem();
        public ItemBaseViewModel GetItemByID();
        public bool AddItem(ItemBaseViewModel itemVM);
        public bool Updatetem(ItemBaseViewModel itemVM);
        public bool RemoveItem(ItemBaseViewModel itemVM);

    }
}
