using SCM.Model.Items;

namespace SCM.Interfaces.Item
{
    public interface IIteamMasterService
    {
        public List<ItemMasterViewModel> GetAllItem();
        public ItemMasterViewModel GetItemByID(int ID);
        public bool AddItem(ItemMasterViewModel itemVM);
        public bool Updatetem(ItemMasterViewModel itemVM);
        public bool RemoveItem(ItemMasterViewModel itemVM);

    }
}
