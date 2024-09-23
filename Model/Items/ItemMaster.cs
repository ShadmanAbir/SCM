namespace SCM.Model.Items
{
    public class ItemMaster : BaseEntity
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
