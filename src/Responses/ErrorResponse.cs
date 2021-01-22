using AlbedoTeam.Accounts.Contracts.Common;

namespace AlbedoTeam.Accounts.Contracts.Responses
{
    public interface ErrorResponse
    {
        ErrorType ErrorType { get; set; }
        string ErrorMessage { get; set; }
    }
}