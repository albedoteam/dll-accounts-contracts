using System;

namespace AlbedoTeam.Accounts.Contracts.Events
{
    public interface AccountDeleted
    {
        string Id { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}