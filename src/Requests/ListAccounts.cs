using System.Collections.Generic;

namespace AlbedoTeam.Accounts.Contracts.Requests
{
    public interface ListAccounts
    {
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
        Dictionary<string, string> FilterBy { get; set; }
    }
}