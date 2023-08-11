using Newtonsoft.Json;
using Flurl.Http;
using eWellness.WinForms.Properties;
using eWellness.WinForms;

namespace eWellness.WinForms;

public class APIService
{
    private readonly string _resource;
    private readonly string _endpoint = AppSettings.Default.APIUrl;
    public static JsonSerializer JsonSerializerSettings { get; set; }

    public APIService(string resource)
    {
        _resource = resource;
    }

    public async Task<T> Get<T>(object? search = null)
    {
        var query = "";
        if (search is not null)
        {
            query = await search.ToQueryString();
        }
        var url = $"{_endpoint}{_resource}?{query}";
        return await url.GetJsonAsync<T>();
    }

    public async Task<T> GetById<T>(int id)
    {
        return await $"{_endpoint}{_resource}/{id}".GetJsonAsync<T>();
    }

    public async Task<T> Post<T>(object request)
    {
        return await $"{_endpoint}{_resource}".PostJsonAsync(request).ReceiveJson<T>();
    }

    public async Task<T> Put<T>(int id, object request)
    {
        return await $"{_endpoint}{_resource}/{id}".PutJsonAsync(request).ReceiveJson<T>();
    }
    public async Task<T> Delete<T>(int id)
    {
        return await $"{_endpoint}{_resource}/{id}".DeleteAsync().ReceiveJson<T>();
    }

}