using SCM.Interfaces.Item;
using SCM.Model;
using SCM.Model.Items;

namespace SCM.Services.Item
{
    public class ItemBaseService:IIteamBaseService
    {
        private readonly SCMContext _context;
        public ItemBaseService(SCMContext context)
        {
            _context = context;
        }

        public bool AddItem(ItemBaseViewModel itemVM)
        {
            throw new NotImplementedException();
        }

        public List<ItemBaseViewModel> GetAllItem()
        {
            throw new NotImplementedException();
        }

        public ItemBaseViewModel GetItemByID()
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(ItemBaseViewModel itemVM)
        {
            throw new NotImplementedException();
        }

        public bool Updatetem(ItemBaseViewModel itemVM)
        {
            throw new NotImplementedException();
        }
    }
}
