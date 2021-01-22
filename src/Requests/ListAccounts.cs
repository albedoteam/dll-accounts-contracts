using System.Collections.Generic;
using AlbedoTeam.Accounts.Contracts.Common;

namespace AlbedoTeam.Accounts.Contracts.Requests
{
    public interface ListAccounts
    {
        bool ShowDeleted { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
        Dictionary<FilterByField, string> FilterBy { get; set; }
        OrderByField OrderBy { get; set; }
        Sorting Sorting { get; set; }
    }
}