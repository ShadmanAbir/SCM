namespace SCM.Model.Items
{
    public class Category_tbl : BaseEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentID { get; set; }
    }
}
