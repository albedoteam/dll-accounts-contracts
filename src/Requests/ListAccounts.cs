namespace Accounts.Contracts.Requests
{
    public interface ListAccounts
    {
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
    }
}