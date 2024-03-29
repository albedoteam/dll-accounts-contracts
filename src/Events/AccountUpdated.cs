﻿using System;

namespace AlbedoTeam.Accounts.Contracts.Events
{
    public interface AccountUpdated
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string IdentificationNumber { get; set; }
        bool Enabled { get; set; }

        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}