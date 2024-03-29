﻿using System;

namespace AlbedoTeam.Accounts.Contracts.Responses
{
    public interface AccountResponse
    {
        string Id { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        string IdentificationNumber { get; set; }
        bool Enabled { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}