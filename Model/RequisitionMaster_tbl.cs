using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SCM.Model
{
    public class RequisitionMaster_tbl :BaseEntity
    {
        [Key]
        public int RequisitionID { get; set; }

        [Required]
        [StringLength(30)] 
        public string RequisitionNo { get; set; }
        [Column(TypeName = "date")] 
        public DateTime RequisitionDate { get; set; }
        [Column(TypeName = "date")] 
        public DateTime EstimatedRequiredDate { get; set; }
    }
}
