
using System;
using URLShortner.Controllers.Model;

namespace URLShortner.Services
{
    public class URJShorternSeervices : IURLlShortnerService
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
         private readonly Random _random = new();
        public Task<string?> GetOriginalUrlAsync(string shortCode)
        {
            throw new NotImplementedException();
        }

        public Task<string> ShortenUrlAsync(string originalUrl)
        {
            //valite
            var shortCode = GenerateShortCode();

            //genarate short code
            var shortUrl = "newgen.ly" + shortCode;
            var mapping = new UrlMapping();
            mapping.ShortenUrl= shortUrl;
            mapping.longUrl = originalUrl;
           //add perfix if needed
           //add into database
           throw new NotImplementedException();

        }

        private string GenerateShortCode(int length = 6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
