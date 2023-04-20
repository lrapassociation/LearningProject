using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CoreOSR.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly CoreOSRAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new CoreOSRAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
