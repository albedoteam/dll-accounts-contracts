namespace Accounts.Contracts.Requests
{
    public interface CreateAccount
    {
        string Name { get; set; }
        string Description { get; set; }
        string IdentificationNumber { get; set; }
        bool Enabled { get; set; }
    }
}