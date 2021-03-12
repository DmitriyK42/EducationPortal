﻿using System.Collections.Generic;
using EducationPortal.WEB.MVC.Models;

namespace EducationPortal.WEB.MVC.ViewModels
{
    public class IndexMaterialsViewModel
    {
        public PageViewModel PageViewModel { get; set; }

        public IEnumerable<MaterialModel> Materials { get; set; }
    }
}
