namespace Users.Dto
{
    public class EmployeeDto
    {
        public EmployeeDto(int id, string name, string contact, string email, decimal salary, EmployeeTypeDto type)
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
        public EmployeeTypeDto Type { get; }
    }
}