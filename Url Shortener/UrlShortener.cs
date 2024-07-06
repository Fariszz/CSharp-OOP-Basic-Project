namespace Url_Shortener;

public class UrlShortener
{
    private UrlStorage urlStorage;
    private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private Random random;

    public UrlShortener()
    {
        urlStorage = new UrlStorage();
        random = new Random();
    }

    public string? RetrieveUrl(string shortUrl)
    {
        return urlStorage.GetOriginalUrl(shortUrl);
    }

    public string ShortenUrl(string longUrl)
    {
        string shortUrl = GenerateShortUrl();
        
        while (urlStorage.GetOriginalUrl(shortUrl) != null)
        {
            shortUrl = GenerateShortUrl();
        }

        urlStorage.AddUrl(shortUrl, longUrl);

        return shortUrl;
    }

    private string GenerateShortUrl()
    {
        char[] shortUrl = new char[6];
        for (int i = 0; i < 6; i++)
        {
            shortUrl[i] = Characters[random.Next(Characters.Length)];
        }

        return new string(shortUrl);
    }


}
