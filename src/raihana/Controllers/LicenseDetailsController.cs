using Microsoft.AspNetCore.Mvc;
using raihana.Models;
using raihana.Services;

namespace raihana.Controllers
{
    [Route("license")]
    public class LicenseDetailsController : Controller
    {
        public ILicenseDetailsService _licenseDetailsService;

        public LicenseDetailsController(ILicenseDetailsService licenseDetailsService)
        {
            _licenseDetailsService = licenseDetailsService;
        }

        [HttpGet("{id}")]
        [Route("/getinfo")]
        public License GetLicenseInfo(string id)
        {
            return _licenseDetailsService.GetLicenseDetails(id);
        }
    }
}
