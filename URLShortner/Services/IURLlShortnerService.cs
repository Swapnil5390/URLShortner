namespace URLShortner.Services
{
    public interface IURLlShortnerService
    {
        
            Task<string> ShortenUrlAsync(string originalUrl);
            Task<string?> GetOriginalUrlAsync(string shortCode);
        //Task<string?> Tak(string shortCode);

    }


}
