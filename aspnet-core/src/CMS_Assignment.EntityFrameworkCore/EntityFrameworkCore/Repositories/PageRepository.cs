using System;
using System.Collections.Generic;
using System.Text;
using CMS_Assignment.Pages;
using Abp.EntityFrameworkCore;

namespace CMS_Assignment.EntityFrameworkCore.Repositories
{
    public class PageRepository : CMS_AssignmentRepositoryBase<Page>
    {
        public PageRepository(IDbContextProvider<CMS_AssignmentDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Page GetCMSContent(int pageID)
        {
            return Get(pageID);
        }

        public Page InsertOrUpdateCMSContent(Page page)
        {
            var query = Get(page.Id);
            if (query == null)
            {
                return Insert(page);
            }
            else
            {
                return Update(query);
            }
        }
    }
}
