namespace Accounts.Dto
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public AccountTypeDto Type { get; set; }
    }
}