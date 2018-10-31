namespace Users.Dto
{
    public class EmployeeDto
    {
        public EmployeeDto(int id, string name, decimal salary, EmployeeTypeDto type)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Type = type;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Salary { get; }
        public EmployeeTypeDto Type { get; }
    }
}