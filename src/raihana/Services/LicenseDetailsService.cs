using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using raihana.Models;

namespace raihana.Services
{
    public class LicenseDetailsService : ILicenseDetailsService
    {
        private List<License> MockLicenses { get; set; }

        public LicenseDetailsService()
        {
            PopulateMockLicensesList();
        }

        private void PopulateMockLicensesList()
        {
            MockLicenses = new List<License>();
            var file = Path.Combine(Environment.CurrentDirectory, @"mock_data.csv");
            try
            {
                MockLicenses = File.ReadAllLines(file)
                    .Skip(1)
                    .Select(v => License.FromCsv(v))
                    .ToList();
                Console.WriteLine(MockLicenses.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public License GetLicenseDetails(string id)
        {
            return MockLicenses.SingleOrDefault(record => record.LicenseId == id);
        }

        public List<License> GetAllLicenses()
        {
            return MockLicenses;
        }
    }
}