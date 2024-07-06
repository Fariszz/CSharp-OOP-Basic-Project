namespace Url_Shortener;

class Program {
    static void Main(string[] args) {
        UrlShortener urlShortener = new UrlShortener();

        string longUrl = "https://www.google.com";
        
        string shortUrl = urlShortener.ShortenUrl(longUrl);
        string? retrievedUrl = urlShortener.RetrieveUrl(shortUrl);
        string domainShortUrl = "https://faris.url/"+shortUrl;

        if (retrievedUrl != null) {
            Console.WriteLine($"Retrieved URL: {retrievedUrl} is from short URL: {domainShortUrl}");
        } else {
            Console.WriteLine("URL not found");
        }
    }
}