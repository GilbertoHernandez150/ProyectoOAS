using OAS.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAS.Domain.Entities
{
    public class Department : BaseEntity
    {
        public required string Name { get; set; }
    }
}
