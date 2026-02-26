namespace OGEDataReading;

using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<IdentityData> FinalList = read($"{System.AppDomain.CurrentDomain.BaseDirectory}\\Francis Tuttle Identities_Basic.csv");
        Console.WriteLine(FinalList.Count);
        Console.WriteLine(FinalList[0].FirstName);

        /*
        var inactiveCount = from val in FinalList
                            where val.CloudLifecycle.Equals("inactive")
                            select val;

        Console.WriteLine(inactiveCount.Count());
        */



        /*
        var InactiveNames = (from val in FinalList
                             where val.CloudLifecycle.Equals("inactive")
                             orderby val.DisplayName ascending
                             select val.DisplayName).Distinct();

        foreach (var val in InactiveNames)
        {
            Console.WriteLine(val);
        }
        */



        /*
        var InactiveNames2 = (from val in FinalList
                              where val.CloudLifecycle.Equals("inactive")
                              orderby val.DisplayName ascending
                              group val by val.DisplayName into groupedVals
                              select groupedVals).Distinct();

        foreach (var val in InactiveNames2)
        {
            Console.WriteLine($" User Display name: {val.Key}");
            Console.WriteLine($"-----------------------------");

            foreach (var item in val)
            {
                if (item.DisplayName.Equals(val.Key) && item.AccessSourceName != "" && item.AccessDisplayName != "")
                {
                    Console.WriteLine($" User AccesSourceName: {item.AccessSourceName}");
                    Console.WriteLine($" User AccesDisplayName: {item.AccessDisplayName}");
                }
            }
            Console.WriteLine($"");
        }
        */



        /*
        var DepartmentList = (from val in FinalList
                              orderby val.Department ascending
                              select val.Department).Distinct();

        Console.WriteLine($" Total departments {DepartmentList.Count()}");

        foreach (var val in DepartmentList)
        {
            
            Console.WriteLine($" Department: {val}");
            Console.WriteLine($"-----------------------------");
        }
        */



        /*
        var DepartmentCount = (from val in FinalList
                               orderby val.Department ascending
                               group val by val.Department into groupedVals
                               select new { Department = groupedVals.Key, Count = groupedVals.Count() }).Distinct();
        foreach (var val in DepartmentCount)
        {
            Console.WriteLine($" Department: {val.Department} | Count: {val.Count}");
            Console.WriteLine($"-----------------------------");
        }
        */


        /*
        var InactivePerDepartment = (from val in FinalList
                                where val.CloudLifecycle.Equals("inactive")
                                where val.AccessType != ""
                               orderby val.Department ascending
                               group val by val.Department into groupedVals
                               select new { Department = groupedVals.Key, Count = groupedVals.Count() }).Distinct();
        foreach (var val in InactivePerDepartment)
        {
            Console.WriteLine($" Department: {val.Department} | Inactive Employees Count: {val.Count}");
            Console.WriteLine($"-----------------------------");
        }
        */








    }
    public struct IdentityData
    {
        public IdentityData(string displayName, string firstName, string lastname, string workEmail,
         string cloudLifecycle, string identityID, string isManager, string department,
          string jobTitle, string uiD, string accessType, string accessSourceName,
           string accessDisplayName, string accessDescription)
        {
            DisplayName = displayName; FirstName = firstName; Lastname = lastname;
            WorkEmail = workEmail; CloudLifecycle = cloudLifecycle; IdentityID = identityID;
            IsManager = isManager; Department = department; JobTitle = jobTitle;
            UiD = uiD; AccessType = accessType; AccessSourceName = accessSourceName;
            AccessDisplayName = accessDisplayName; AccessDescription = accessDescription;
        }

        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string WorkEmail { get; set; }
        public string CloudLifecycle { get; set; }
        public string IdentityID { get; set; }
        public string IsManager { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string UiD { get; set; }
        public string AccessType { get; set; }
        public string AccessSourceName { get; set; }
        public string AccessDisplayName { get; set; }
        public string AccessDescription { get; set; }
    }
    public static List<IdentityData> read(string fileName)
    {
        List<IdentityData> AllIdentities = new List<IdentityData>();

        string? line;
       
        using StreamReader sr = new StreamReader(fileName);


        List<string[]> lineList = new List<string[]>();


        line = sr.ReadLine();
        string[] temporary;
        int x = 0;


        while (line != null)
        {
            temporary = line.Split(',');


            if (x > 0)
            {
                var p1 = new IdentityData(temporary[0], temporary[1], temporary[2], temporary[3],temporary[4], temporary[5], temporary[6],
                 temporary[7], temporary[8], temporary[9], temporary[10], temporary[11], temporary[12], temporary[13]);

                AllIdentities.Add(p1);
            }
            lineList.Add(temporary);
            line = sr.ReadLine();
            x++;
        }
        sr.Close();
        return AllIdentities;
    }

}

   