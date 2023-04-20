using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CoreOSR.ApiClient;
using CoreOSR.Mobile.MAUI.Core.ApiClient;

namespace CoreOSR
{
    [DependsOn(typeof(CoreOSRClientModule), typeof(AbpAutoMapperModule))]

    public class CoreOSRMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRMobileMAUIModule).GetAssembly());
        }
    }
}