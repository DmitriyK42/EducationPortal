﻿using System;
using System.Collections.Generic;

namespace EducationPortal.DAL.Entities
{
    public class Course : Entity
    {
        // Changed illogical inheritance from Material
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid Owner { get; set; }

        // List<Material>
        public List<Guid> Materials { get; set; }

        // List<Skill>
        public List<Guid> Skills { get; set; }
    }
}
