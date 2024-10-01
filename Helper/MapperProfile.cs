using AutoMapper.Execution;
using AutoMapper;
using SCM.Model.Items;
using SCM.Model.Requisitions;
using SCM.ViewModel.Items;
using SCM.ViewModel.Requisitions;

namespace SCM.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Item, ItemViewModel>().ReverseMap();
            CreateMap<RequisitionMaster, RequisitionMasterViewModel>().ReverseMap();
            CreateMap<RequisitionDetail, RequisitionDetailViewModel>().ReverseMap();
        }
    }
}
