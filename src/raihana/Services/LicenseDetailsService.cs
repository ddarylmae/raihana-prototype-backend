using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using raihana.Models;

namespace raihana.Services
{
    public class LicenseDetailsService : ILicenseDetailsService
    {
        public License GetLicenseDetails(string id)
        {
            return new License{
                FirstName = "Hermione",
                LastName = "Granger",
                Id = "XXXXX444",
            };
        }
    }
}