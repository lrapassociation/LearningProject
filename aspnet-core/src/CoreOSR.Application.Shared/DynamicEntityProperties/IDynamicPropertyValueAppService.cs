﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CoreOSR.DynamicEntityProperties.Dto;

namespace CoreOSR.DynamicEntityProperties
{
    public interface IDynamicPropertyValueAppService
    {
        Task<DynamicPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicPropertyValueDto>> GetAllValuesOfDynamicProperty(EntityDto input);

        Task Add(DynamicPropertyValueDto dto);

        Task Update(DynamicPropertyValueDto dto);

        Task Delete(int id);
    }
}