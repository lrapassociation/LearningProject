using Abp.AspNetZeroCore.Web.Authentication.External;
using Abp.Runtime.Caching;

namespace CoreOSR.Web.Startup.ExternalLoginInfoProviders
{
    public static class ExternalLoginInfoProvidersCacheManagerExtensions
    {
        private const string CacheName = "AppExternalLoginInfoProvidersCache";

        public static ITypedCache<string, ExternalLoginProviderInfo>
            GetExternalLoginInfoProviderCache(this ICacheManager cacheManager)
        {
            return cacheManager.GetCache<string, ExternalLoginProviderInfo>(CacheName);
        }
    }
}