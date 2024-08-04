using OAS.Application.Contract;
using OAS.Application.Dtos;
using OAS.Infrastructure.Interfaces;

namespace OAS.Application.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<ServiceResult<IEnumerable<PersonDto>>> GetAllPersonsAsync()
        {
            var persons = await _personRepository.GetAllAsync();
            var personDtos = persons.Select(p => new PersonDto
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                DateOfBirth = p.DateOfBirth,
                Email = p.Email,
                PhoneNumber = p.PhoneNumber
            });

            return ServiceResult<IEnumerable<PersonDto>>.SuccessResult(personDtos);
        }

        public async Task<ServiceResult<PersonDto>> GetPersonByIdAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null)
            {
                return ServiceResult<PersonDto>.FailureResult("Person not found");
            }

            var personDto = new PersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateOfBirth = person.DateOfBirth,
                Email = person.Email,
                PhoneNumber = person.PhoneNumber
            };

            return ServiceResult<PersonDto>.SuccessResult(personDto);
        }

        public async Task<ServiceResult<PersonDto>> CreatePersonAsync(PersonDto personDto)
        {
            var person = new Person
            {
                FirstName = personDto.FirstName,
                LastName = personDto.LastName,
                DateOfBirth = personDto.DateOfBirth,
                Email = personDto.Email,
                PhoneNumber = personDto.PhoneNumber
            };

            await _personRepository.AddAsync(person);

            personDto.Id = person.Id;

            return ServiceResult<PersonDto>.SuccessResult(personDto, "Person created successfully");
        }

        public async Task<ServiceResult<PersonDto>> UpdatePersonAsync(int id, PersonDto personDto)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null)
            {
                return ServiceResult<PersonDto>.FailureResult("Person not found");
            }

                person.FirstName = personDto.FirstName;
                person.LastName = personDto.LastName;
                person.DateOfBirth = personDto.DateOfBirth;
                person.Email = personDto.Email;
                person.PhoneNumber = personDto.PhoneNumber;
                await _personRepository.UpdateAsync(person);

                return ServiceResult<PersonDto>.SuccessResult(personDto, "Person updated successfully");
        }

        public async Task<ServiceResult<bool>> DeletePersonAsync(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            if (person == null)
            {
                return ServiceResult<bool>.FailureResult("Person not found");
            }

            await _personRepository.DeleteAsync(id);

            return ServiceResult<bool>.SuccessResult(true, "Person deleted successfully");
        }
    }
}
