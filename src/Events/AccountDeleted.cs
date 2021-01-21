using System;

namespace Accounts.Contracts.Events
{
    public interface AccountDeleted
    {
        string Id { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}