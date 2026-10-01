namespace Employee
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeID {  get; set; }
        public double HoursWorked {  get; set; }
        public double HourlyRate { get; set; }

        public Employee(string name, string id, double hoursWorked)
        {
            EmployeeName = name;
            EmployeeID = id;
            HoursWorked = hoursWorked;
            HourlyRate = 9.5;
        }

        public override string ToString()
        {
            return EmployeeName + "(" + EmployeeID + ")";
        }
        public static bool IsvalidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name)
                && name.Length >= 1
                && name.Length <= 50;
        }
        public double Calculatewage()
        {
            return HoursWorked * HourlyRate;
        }



    }
}