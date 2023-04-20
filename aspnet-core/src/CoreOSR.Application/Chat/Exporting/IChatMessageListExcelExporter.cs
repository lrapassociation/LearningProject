using System.Collections.Generic;
using Abp;
using CoreOSR.Chat.Dto;
using CoreOSR.Dto;

namespace CoreOSR.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
