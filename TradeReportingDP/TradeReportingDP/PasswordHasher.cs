using System;
using System.Security.Cryptography;
using System.Text;
namespace TradeReportingDP
{
    internal class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Создаём объект SHA256Managed
            SHA256 sha256 = SHA256.Create();

            // Хешируем пароль
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Преобразуем массив байтов в строку
            return Convert.ToBase64String(hash);
        }
    }
}
