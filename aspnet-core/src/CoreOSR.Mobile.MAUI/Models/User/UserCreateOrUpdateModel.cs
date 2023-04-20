using Abp.AutoMapper;
using CoreOSR.Authorization.Users.Dto;

namespace CoreOSR.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
