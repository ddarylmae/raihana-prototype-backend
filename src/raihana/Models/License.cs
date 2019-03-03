using System;

namespace raihana.Models
{
    public class License 
    {
        public string Id { get; set; }
        public string LicenseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expiry { get; set; }

        public static License FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new License
            {
                Id = values[0],
                FirstName = values[1],
                LastName = values[2],
                Email = values[3],
                Gender = values[4],
                DateOfBirth = DateTime.Parse(values[5]),
                Issued = DateTime.Parse(values[6]),
                Expiry = DateTime.Parse(values[7]),
                LicenseId = values[8],
                Address = values[9],
            };
        }
    }
}