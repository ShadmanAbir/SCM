namespace SCM.Model.Items
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentID { get; set; }
    }
}
