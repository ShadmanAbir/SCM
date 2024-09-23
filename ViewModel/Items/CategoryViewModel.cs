using System.ComponentModel.DataAnnotations;

namespace SCM.Model.Items
{
    public class CategoryViewModel : BaseViewModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentID { get; set; }
    }
}
