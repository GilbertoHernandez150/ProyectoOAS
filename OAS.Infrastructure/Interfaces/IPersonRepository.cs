using OAS.Domain.Core;
using OAS.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAS.Infrastructure.Interfaces
{
    public interface IPersonRepository : BaseRepository<Person>
    {
    }
}