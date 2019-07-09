using Abp.Application.Services;
using CMS_Assignment.Pages.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Assignment.CMS
{
    public interface ICMSService : IApplicationService
    {
        PageDto GetCMSContent(GetSinglePageInput input);
        PageDto InsertOrUpdateCMSContent(PageDto input);
        List<PageDto> GetAll();
    }
}
