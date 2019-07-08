using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CMS_Assignment.Controllers
{
    public abstract class CMS_AssignmentControllerBase: AbpController
    {
        protected CMS_AssignmentControllerBase()
        {
            LocalizationSourceName = CMS_AssignmentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
