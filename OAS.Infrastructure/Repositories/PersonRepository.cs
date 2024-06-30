using System;
using OAS.Domain.Core;
using OAS.Infrastructure.Core;
using OAS.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAS.Infrastructure.Context;

namespace OAS.Infrastructure.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(OASContext context) : base(context)
        {
        }
    }
}
