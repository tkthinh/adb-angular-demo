﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace DemoStaff.Staffs
{
   public class DepartmentLookupDto : EntityDto<Guid>
   {
      public string Name { get; set; }
   }
}