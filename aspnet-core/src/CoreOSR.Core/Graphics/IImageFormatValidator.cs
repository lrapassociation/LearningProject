using System.IO;
using Abp.Extensions;
using Abp.UI;
using SkiaSharp;

namespace CoreOSR.Graphics
{
    public interface IImageFormatValidator
    {
        void Validate(byte[] imageBytes);
    }

    public class SkiaSharpImageFormatValidator : CoreOSRDomainServiceBase, IImageFormatValidator
    {
        public void Validate(byte[] imageBytes)
        {
            var skImage = SKImage.FromEncodedData(imageBytes);
            
            if (skImage == null)
            {
                throw new UserFriendlyException(L("IncorrectImageFormat"));
            }
        }
    }
}