using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Assignment.Pages
{
    public class Page : Entity<int>
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
