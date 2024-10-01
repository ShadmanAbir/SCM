using System.ComponentModel.DataAnnotations;

namespace SCM.ViewModel.Items
{
    public class CategoryViewModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentID { get; set; }
    }
}
