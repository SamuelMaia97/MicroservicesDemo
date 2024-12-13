using System.Text.Json;

public class ProductServiceClient
{
    private readonly HttpClient _httpClient;

    public ProductServiceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> ValidateProductAsync(int productId)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/product/validate/{productId}");
            response.EnsureSuccessStatusCode(); 

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<bool>(content);
        }
        catch (HttpRequestException)
        {
            return false;
        }
    }
}
