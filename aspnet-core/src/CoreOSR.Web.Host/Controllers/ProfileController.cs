using Abp.AspNetCore.Mvc.Authorization;
using CoreOSR.Authorization.Users.Profile;
using CoreOSR.Graphics;
using CoreOSR.Storage;

namespace CoreOSR.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageFormatValidator imageFormatValidator) :
            base(tempFileCacheManager, profileAppService, imageFormatValidator)
        {
        }
    }
}