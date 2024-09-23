namespace SCM.Model.Items
{
    public class ItemBase_tbl : BaseEntity
    {
        public int BaseItemID { get; set; }
        public string BaseItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
