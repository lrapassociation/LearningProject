using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    [DependsOn(typeof(CoreOSRCoreSharedModule))]
    public class CoreOSRApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRApplicationSharedModule).GetAssembly());
        }
    }
}