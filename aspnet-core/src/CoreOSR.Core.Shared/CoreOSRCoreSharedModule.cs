using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CoreOSR
{
    public class CoreOSRCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CoreOSRCoreSharedModule).GetAssembly());
        }
    }
}