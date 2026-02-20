namespace OGEDataReading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public struct Data
    {
        public Data(string displayName, string firstName, string lastname, string workEmail,
         string cloudLifecycle, string identityID, string isManager, string department,
          string jobTitle, string uiD, string accessType, string accessSourceName,
           string accessDisplayName, string accessDescription)
        {
            DisplayName = displayName;
            FirstName = firstName;
            Lastname = lastname;
            WorkEmail = workEmail;
            CloudLifecycle = cloudLifecycle;
            IdentityID = identityID;
            IsManager = isManager;
            Department = department;
            JobTitle = jobTitle;
            UiD = uiD;
            AccessType = accessType;
            AccessSourceName = accessSourceName;
            AccessDisplayName = accessDisplayName;
            AccessDescription = accessDescription;

        }

        public string DisplayName { get; set; } public string FirstName { get; set; }
        public string Lastname { get; set; } public string WorkEmail { get; set; }
        public string CloudLifecycle { get; set; } public string IdentityID { get; set; }
         public string IsManager { get; set; } public string Department { get; set; }
        public string JobTitle { get; set; } public string UiD { get; set; }
        public string AccessType { get; set; } public string AccessSourceName { get; set; }
        public string AccessDisplayName { get; set; } public string AccessDescription { get; set; }  


    }
}
