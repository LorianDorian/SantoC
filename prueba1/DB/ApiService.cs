using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http.Json;

public class ApiService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<MenuItem>> FetchMenuItemsFromApiAsync()
    {
        string apiUrl = "https://yourserver.com/api/menu"; // ← Replace with your real URL

        var items = await _httpClient.GetFromJsonAsync<List<MenuItem>>(apiUrl);
        return items ?? new List<MenuItem>();
    }
}