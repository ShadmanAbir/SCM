using System.ComponentModel.DataAnnotations;

namespace SCM.Model.Items
{
    public class ItemMasterViewModel : BaseViewModel
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
