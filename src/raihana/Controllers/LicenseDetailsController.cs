using Microsoft.AspNetCore.Mvc;
using raihana.Models;
using raihana.Services;
using System.Collections.Generic;

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

        [HttpGet("{licenseId}")]
        public License GetLicenseInfo(string licenseId)
        {
            return _licenseDetailsService.GetLicenseDetails(licenseId);
        }

        [HttpGet]
        public List<License> GetAllLicenses()
        {
            return _licenseDetailsService.GetAllLicenses();
        }
    }
}
