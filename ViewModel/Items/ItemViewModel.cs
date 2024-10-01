using System.ComponentModel.DataAnnotations;

namespace SCM.ViewModel.Items
{
    public class ItemViewModel
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
