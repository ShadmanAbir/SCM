namespace SCM.Model
{
    public class ItemMaster_tbl:BaseEntity
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
    }
}
