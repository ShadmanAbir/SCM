using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SCM.ViewModel.Requisitions
{
    public class RequisitionDetailViewModel
    {
        public int RequisitionDetailID { get; set; }
        public int RequisitionID { get; set; }
        public int ItemID { get; set; }

        [Column(TypeName = "decimal(18, 10)")]
        public decimal RequiredQTY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetDate { get; set; }
        public bool? IsCompleted { get; set; }
        public string? Remarks { get; set; }
        public RequisitionMasterViewModel Requisition { get; set; }
    }
}
