﻿using System;

namespace EducationPortal.DAL.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public int Identifier { get; set; }

        public string Description { get; set; }
    }
}
