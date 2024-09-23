namespace SCM.Model.Items
{
    public class ItemBase : BaseEntity
    {
        public int BaseItemID { get; set; }
        public string BaseItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
