using Abp.Application.Services;
using Abp.Domain.Repositories;
using CMS_Assignment.Pages.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CMS_Assignment.Pages;

namespace CMS_Assignment.CMS
{
    public class CMSService : CMS_AssignmentAppServiceBase, ICMSService
    {
        private readonly IRepository<Page> _pageRepository;

        public CMSService(IRepository<Page> pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public List<PageDto> GetAll()
        {
            var pages = _pageRepository.GetAllList();
            return new List<PageDto>(ObjectMapper.Map<List<PageDto>>(pages));
        }

        public PageDto GetCMSContent(GetSinglePageInput input)
        {
            var page = _pageRepository.Get(input.id);
            return Mapper.Map<PageDto>(page);
        }

        public PageDto InsertOrUpdateCMSContent(PageDto input)
        {
            var page = _pageRepository.FirstOrDefault(input.id);
            if(page == null)
            {
                page = new Page()
                {
                    Name = input.pageName,
                    Content = input.pageContent
                };
                var result = _pageRepository.Insert(page);
                return Mapper.Map<PageDto>(result);
            }
            else
            {
                page.Name = input.pageName;
                page.Content = input.pageContent;
                var result = _pageRepository.Update(page);
                return Mapper.Map<PageDto>(result);
            }
        }
    }
}
