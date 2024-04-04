using System.Security.Cryptography;
using System.Text;

namespace Helpers
{
    public static class PasswordHelper
    {
        public static string Hash(string message)
            => Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(message)));
    }
}