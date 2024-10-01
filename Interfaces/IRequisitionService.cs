using SCM.ViewModel.Requisitions;

namespace SCM.Interfaces
{
    public interface IRequisitionService
    {
        public Task<List<RequisitionMasterViewModel>> GetAllRequisitionOfUser();
        public Task<RequisitionMasterViewModel> GetRequisitionByID(int ID);
        public ValueTask<bool> AddRequisition(RequisitionMasterViewModel reqVM);
        public ValueTask<bool> UpdateRequisition(int id, RequisitionMasterViewModel reqVM);
        public ValueTask<bool> Removerequisition(int id);
    }
}
