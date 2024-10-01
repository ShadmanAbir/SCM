using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SCM.Model.Requisitions
{
    public class RequisitionDetail : BaseEntity
    {
        [Key]
        public int RequisitionDetailID { get; set; }
        [ForeignKey("RequisitionMaster")]
        public int RequisitionID { get; set; }
        public int ItemID { get; set; }

        [Column(TypeName = "decimal(18, 10)")]
        public decimal RequiredQTY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetDate { get; set; }
        public bool? IsCompleted { get; set; }
        public string? Remarks { get; set; }

        public RequisitionMaster? RequisitionMaster { get; set; }
    }
}
