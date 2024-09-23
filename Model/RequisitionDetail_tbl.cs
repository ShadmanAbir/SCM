using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SCM.Model
{
    public class RequisitionDetail_tbl
    {
        [Key] 
        public int RequisitionDetailID { get; set; }
        public int RequisitionID { get; set; }
        public int MaterialID { get; set; }
        public int InventoryID { get; set; }

        [Column(TypeName = "decimal(18, 10)")] public decimal RequiredQTY { get; set; }

        [Column(TypeName = "date")] public DateTime? TargetDate { get; set; }


        public bool IsApproved { get; set; }
        public bool? IsCompleted { get; set; }

        [Column(TypeName = "decimal(18, 10)")] public decimal? LastPurchasePrice { get; set; }

        [Column(TypeName = "date")] public DateTime? LastPurchaseDate { get; set; }

        public string? Remarks { get; set; }
    }
}
