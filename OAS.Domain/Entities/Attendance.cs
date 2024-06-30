using OAS.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAS.Domain.Entities
{
    public class Attendance : BaseEntity
    {
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }
    }
}

