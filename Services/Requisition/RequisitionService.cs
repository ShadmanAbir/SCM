using SCM.Interfaces;
using SCM.Model.Items;
using SCM.Model;
using SCM.ViewModel.Requisitions;
using AutoMapper;
using SCM.Model.Requisitions;

namespace SCM.Services.Requisition
{
    public class RequisitionService : IRequisitionService
    {
        private readonly SCMContext _scmContext;
        private readonly IMapper _mapper;
        public RequisitionService(SCMContext scmContext,IMapper mapper)
        {

            _scmContext = scmContext;
            _mapper = mapper;

        }
        public ValueTask<bool> AddRequisition(RequisitionMasterViewModel reqVM)
        {
            _scmContext.RequisitionMaster.AddAsync(_mapper.Map<RequisitionMaster>(reqVM));
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public Task<List<RequisitionMasterViewModel>> GetAllRequisitionOfUser()
        {
            throw new NotImplementedException();
        }

        public Task<RequisitionMasterViewModel> GetRequisitionByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> Removerequisition(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateRequisition(int id, RequisitionMasterViewModel reqVM)
        {
            throw new NotImplementedException();
        }
    }
}
