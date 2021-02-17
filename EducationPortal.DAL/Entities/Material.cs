﻿using System;

namespace EducationPortal.DAL.Entities
{
    public abstract class Material : Entity
    {
        public string Name { get; set; }

        // Account
        public Guid Owner { get; set; }

        public string MaterialType { get; set; }

        // Can be Null
        public string Source { get; set; }
    }
}
