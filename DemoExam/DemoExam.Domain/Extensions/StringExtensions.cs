using System.Security.Cryptography;
using System.Text;

namespace DemoExam.Domain.Extensions;

public static class StringExtensions
{
    public static string ComputeHash(this string str)
    {
        return Convert.ToBase64String(SHA1.HashData(Encoding.UTF8.GetBytes(str)));
    }
}