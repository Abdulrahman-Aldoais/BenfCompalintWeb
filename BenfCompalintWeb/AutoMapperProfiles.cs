using AutoMapper;
using BenfCompalintWeb.Areas.AdminService.Model;
using BenfCompalintWeb.Areas.AdminService.ViewModel;
using BenfCompalintWeb.Areas.UsersService.ViewModel;

namespace BenfCompalintWeb
{
    public class UploadProfile : Profile
    {
        //public UploadProfile()
        //{
        //    CreateMap<Models.InputUpload, Data.Uploads>()
        //        .ForMember(u => u.Id, op => op.Ignore())
        //        .ForMember(u => u.UploadDate, op => op.Ignore());

        //    CreateMap<Data.Uploads, Models.UploadViewModel>();
        //}
    }

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser,UserViewModel >()
                .ForMember(u=>u.Password , op=>op.MapFrom(u=>u.PasswordHash !=null));

            CreateMap<ApplicationUser, AdminViewModel>()
                .ForMember(u => u.Password, op => op.MapFrom(u => u.PasswordHash != null));
        }
    }
}
