﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.Entities
{
    internal class CompanyCreationResource
    {
        public int CompanyId { get; set; }
        public int AdminId { get; set; }
        public int UserId { get; set; }
    }
}
