using System.ComponentModel.DataAnnotations;

namespace SCM.Model.Items
{
    public class ItemBaseViewModel : BaseViewModel
    {
        [Key]
        public int BaseItemID { get; set; }
        public string BaseItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
