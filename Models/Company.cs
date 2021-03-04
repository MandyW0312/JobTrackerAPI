namespace JobTrackerAPI.Models
{
    public class Company
    {
        //   Id
        public int Id { get; set; }
        //   Position (Position: text)
        public string Position { get; set; }
        //   Technology (Technology: text)
        public string Technology { get; set; }
        //   Contact Name (ContactName: text)
        public string ContactName { get; set; }
        //   Contact Email (ContactEmail: text)
        public string ContactEmail { get; set; }
        //   Remote (T/F) (Remote: boolean)
        public bool Remote { get; set; }
        //   Contact Count (ContactCount: int)
        public int ContactCount { get; set; }
        //   Name of the Company (CompanyName: text)
        public string CompanyName { get; set; }
        //   Salary (Salary: int)
        public int Salary { get; set; }
        //   Benefits (T/F) (Benefits: boolean)
        public bool Benefits { get; set; }
        //   Company Logo (CompanyLogo: text)    
        public string CompanyLogo { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
    }
}