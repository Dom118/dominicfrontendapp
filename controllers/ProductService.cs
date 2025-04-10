using System.Net.Http.Json;
using ProductFE.Models; 
using Microsoft.AspNetCore.Components.Forms;

namespace FeProduct.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
    
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // Get all products
        public async Task<List<Product>> GetProductsAsync()
        {
            // Makes an HTTP GET request to fetch the product list from the API.
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");
        }

        // Create and post a method
        public async Task CreateProductAsync(Product product)
        {
            await _httpClient.PostAsJsonAsync("api/products", product);
        }

        // Delete a product
        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/products/{id}");
        }

        // Search an id and retive
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
        }

        public async Task UpdateProductAsync(int id , Product product)
        {
            await _httpClient.PutAsJsonAsync($"api/products/{id}", product);
        }

        public async Task UploadProductImageAsync(int productId, IBrowserFile file)
        {
            var content = new MultipartFormDataContent();
            var streamContent = new StreamContent(file.OpenReadStream(maxAllowedSize: 1024 * 1024 * 15)); // e.g., 15 MB max
            content.Add(streamContent, "file", file.Name);
            await _httpClient.PostAsync($"api/products/{productId}/upload-image", content);
        }

        
    }
}
