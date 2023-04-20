using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using CoreOSR.Queries.Container;
using System;

namespace CoreOSR.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}