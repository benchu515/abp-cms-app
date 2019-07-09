using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS_Assignment.Pages.Dto
{
    [AutoMapFrom(typeof(Page))]
    public class PageDto : EntityDto<int>
    {
        public int id { get; set; }
        public string pageName { get; set; }
        public string pageContent { get; set; }
    }
}
