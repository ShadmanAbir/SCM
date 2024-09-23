using SCM.Model;

namespace SCM.Services.Item
{
    public class ItemService
    {
        private readonly SCMContext _context;
        public ItemService(SCMContext context)
        {
            _context = context;
        }


    }
}
