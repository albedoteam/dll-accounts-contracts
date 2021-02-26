namespace AlbedoTeam.Accounts.Contracts.Requests
{
    public interface CreateAccount
    {
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        string IdentificationNumber { get; set; }
        bool Enabled { get; set; }
    }
}