namespace AlbedoTeam.Accounts.Contracts.Requests
{
    public interface GetAccount
    {
        string Id { get; set; }
        bool ShowDeleted { get; set; }
    }
}