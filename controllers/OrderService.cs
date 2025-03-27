// using System.Net.Http.Json;

// namespace FeOrder.Services
// {
//     public class OrderService
//     {
//         private readonly HttpClient _httpClient;
    
//         public OrderService(HttpClient httpClient)
//         {
//             _httpClient = httpClient;
//         }
//         // Get all products
//         public async Task<List<Order>> GetOrderAsync()
//         {
//             // Makes an HTTP GET request to fetch the product list from the API.
//             return await _httpClient.GetFromJsonAsync<List<Order>>("api/orders");
//         }

//         // Search an id and retive
//         public async Task<Order?> GetOrderByIdAsync(int id)
//         {
//             return await _httpClient.GetFromJsonAsync<Order>($"api/orders/{id}");
//         }


//     }
// }