using System;
using raihana.Models;

namespace raihana.Services
{
    public interface ILicenseDetailsService
    {
        License GetLicenseDetails(string id);
    }
}