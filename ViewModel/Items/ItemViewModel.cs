using System.ComponentModel.DataAnnotations;

namespace SCM.Model.Items
{
    public class ItemViewModel : BaseViewModel
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
