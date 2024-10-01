using AutoMapper.Execution;
using AutoMapper;
using static System.Reflection.Metadata.BlobBuilder;
using SCM.Model.Items;
using SCM.Model.Requisitions;

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
