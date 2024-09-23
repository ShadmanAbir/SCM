namespace SCM.Model
{
    public class BaseViewModel
    {
        public bool? IsDeleted { get; set; }
        public bool? IsApproved { get; set; }
        public int? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
