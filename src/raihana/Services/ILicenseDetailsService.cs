using System;
using System.Collections.Generic;
using raihana.Models;

namespace raihana.Services
{
    public interface ILicenseDetailsService
    {
        License GetLicenseDetails(string id);
        List<License> GetAllLicenses();
    }
}