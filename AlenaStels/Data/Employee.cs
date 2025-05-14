namespace AlenaStels.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public required string FIO { get; set; }

        public bool IsActive{ get; set; }=true;

    }
}
