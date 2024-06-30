using System;
using OAS.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAS.Application.Contract
{
    public interface IPersonService
    {
        Task<ServiceResult<IEnumerable<PersonDto>>> GetAllPersonsAsync();
        Task<ServiceResult<PersonDto>> GetPersonByIdAsync(int id);
        Task<ServiceResult<PersonDto>> CreatePersonAsync(PersonDto person);
        Task<ServiceResult<PersonDto>> UpdatePersonAsync(int id, PersonDto person);
        Task<ServiceResult<bool>> DeletePersonAsync(int id);
    }
}
