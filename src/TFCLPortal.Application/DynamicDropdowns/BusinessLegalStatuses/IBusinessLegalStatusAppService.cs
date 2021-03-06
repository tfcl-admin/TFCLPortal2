using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFCLPortal.DynamicDropdowns.Dto;

namespace TFCLPortal.DynamicDropdowns.BusinessLegalStatuses
{
    public interface IBusinessLegalStatusAppService : IApplicationService
    {
        Task<ListResultDto<BusinessLegalStatusListDto>> GetAllBusinessLegalStatus();
        Task CreateBusinessLegalStatus(CreateBusinessLegalStatusDto input);
        List<BusinessLegalStatusListDto> GetAllList();
    }
}
