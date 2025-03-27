using System.Net.Http.Json;
using UserFE.Models; 

namespace FeUser.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
    
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> HandleLogin(User user)
        {
            
            // Handle successful login (e.g., redirect to another page)
            return await _httpClient.PostAsJsonAsync<User>("api/user/login", user);  
          
        }
    }
}