﻿using System;
using System.Collections.Generic;

namespace EducationPortal.DAL.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IList<ProfileSkill> ProfileSkills { get; set; }

        public virtual IEnumerable<Course> Courses { get; set; }
    }
}
