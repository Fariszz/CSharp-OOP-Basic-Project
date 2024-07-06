namespace Url_Shortener;

public class UrlStorage
{
    public Dictionary<string, string> urlMapping;

    public UrlStorage()
    {
        urlMapping = new Dictionary<string, string>();
    }

    public void AddUrl(string shortUrl, string longUrl)
    {
        urlMapping.Add(shortUrl, longUrl);
    }

    public string? GetOriginalUrl(string shortUrl)
    {
        if (urlMapping.ContainsKey(shortUrl))
        {
            return urlMapping[shortUrl];
        }
        
        return null;
    }
}
