using Microsoft.AspNetCore.Antiforgery;
using CMS_Assignment.Controllers;

namespace CMS_Assignment.Web.Host.Controllers
{
    public class AntiForgeryController : CMS_AssignmentControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
