namespace AlbedoTeam.Accounts.Contracts.Requests
{
    public interface UpdateAccount
    {
        string Id { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        string IdentificationNumber { get; set; }
        bool Enabled { get; set; }
    }
}