﻿using System;
using System.Security.Principal;

namespace Legend.Domain
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

