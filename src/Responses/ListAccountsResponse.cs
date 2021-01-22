using System.Collections.Generic;
using AlbedoTeam.Accounts.Contracts.Common;

namespace AlbedoTeam.Accounts.Contracts.Responses
{
    public interface ListAccountsResponse
    {
        int Page { get; set; }
        int PageSize { get; set; }
        int RecordsInPage { get; set; }
        int TotalPages { get; set; }
        Dictionary<FilterByField, string> FilterBy { get; set; }
        OrderByField OrderBy { get; set; }
        Sorting Sorting { get; set; }
        List<AccountResponse> Items { get; set; }
    }
}