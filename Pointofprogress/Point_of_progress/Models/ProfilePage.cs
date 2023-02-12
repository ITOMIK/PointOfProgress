using System.Collections.Generic;

namespace Point_of_progress.Models
{
    public class ProfilePage
    {
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public int companyid { get; set; }
        public List<Company> CompanyList { get; set; }
        public bool isreg { get; set; }
    }
}
