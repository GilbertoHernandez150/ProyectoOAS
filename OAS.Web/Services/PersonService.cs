using OAS.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OAS.web.Services
{
    public class PersonService
    {
        private readonly HttpClient _httpClient;

        public PersonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PersonDto>> GetAllPersonsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PersonDto>>("api/person");
        }

        public async Task<PersonDto> GetPersonByIdAsync(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<PersonDto>($"api/person/{id}");
        }

        public async Task<HttpResponseMessage> CreatePersonAsync(PersonDto person)
        {
            return await _httpClient.PostAsJsonAsync("api/person", person);
        }

        public async Task<HttpResponseMessage> UpdatePersonAsync(PersonDto person)
        {
            return await _httpClient.PutAsJsonAsync($"api/person/{person.Id}", person);
        }

        public async Task<HttpResponseMessage> DeletePersonAsync(Guid id)
        {
            return await _httpClient.DeleteAsync($"api/person/{id}");
        }
    }
}
