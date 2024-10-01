using SCM.Interfaces;
using SCM.Model.Items;
using SCM.Model;
using SCM.ViewModel.Requisitions;
using AutoMapper;
using SCM.Model.Requisitions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCM.ViewModel.Items;

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
            _scmContext.AddAsync(_mapper.Map<RequisitionMaster>(reqVM));
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public Task<List<RequisitionMasterViewModel>> GetAllRequisitionOfUser()
        {
            return _mapper.ProjectTo<RequisitionMasterViewModel>(_scmContext.RequisitionMaster.Include(a => a.Details)).ToListAsync();
        }

        public Task<RequisitionMasterViewModel> GetRequisitionByID(int ID)
        {
            return _scmContext.RequisitionMaster
          .SingleOrDefaultAsync(a => a.RequisitionID == ID && a.IsDeleted == false)
          .ContinueWith(task =>
          {
              var item = task.Result;

              if (item == null)
              {
                  throw new FileNotFoundException();
              }
              return _mapper.Map<RequisitionMasterViewModel>(item);
          });
        }

        public ValueTask<bool> Removerequisition(int id)
        {
            var data = _scmContext.RequisitionMaster.FindAsync(id).Result;
            data.IsDeleted = true;
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

        public ValueTask<bool> UpdateRequisition(int id, RequisitionMasterViewModel reqVM)
        {
            var data = _scmContext.RequisitionMaster.Include(a => a.Details).SingleOrDefaultAsync(a => a.RequisitionID == id).Result;
            data.EstimatedRequiredDate = reqVM.EstimatedRequiredDate;
            foreach (var item in data.Details)
            {
                item.IsDeleted = true;
            }
            foreach (var item in reqVM.Details)
            {
                if (item.RequisitionDetailID == 0)
                {
                    data.Details.Add(_mapper.Map<RequisitionDetail>(item));
                }
                else
                {
                    var detailtoupdate = data.Details.SingleOrDefault(a => a.RequisitionDetailID == item.RequisitionDetailID);
                    
                    data.Details.Remove(detailtoupdate);
                    
                    detailtoupdate.RequiredQTY = item.RequiredQTY;
                    detailtoupdate.IsDeleted = false;
                    detailtoupdate.ItemID = item.ItemID;
                    detailtoupdate.Remarks = item.Remarks;
                    
                    data.Details.Add(detailtoupdate);
                }
            }
            _scmContext.Update(data);
            return ValueTask.FromResult(_scmContext.SaveChangesAsync().Result == 1 ? true : false);
        }

    }
}
