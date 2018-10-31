namespace Users.Entities
{
    public class Employee
    {
        public Employee(int id, string name, string contact, string email, decimal salary, EmployeeType type)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = contact;
            this.Email = email;
            this.Salary = salary;
            this.Type = type;
        }
        public int Id { get; }
        public string Name { get; }
        public string Contact { get; }
        public string Email { get; }
        public decimal Salary { get; }
        public EmployeeType Type { get; }
    }
}