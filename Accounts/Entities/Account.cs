namespace Accounts.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public AccountType Type { get; set; }
    }
}