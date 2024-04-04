using Microsoft.AspNetCore.Mvc;

namespace Uvali.API.Constants
{
    public readonly struct Error
    {
        public const string USER_DOES_NOT_EXIST = "This user doesn't exist";
        public const string USER_EXIST = "This user already exist";

        public static readonly ObjectResult DB_CONNECTION_FAILED = new("Database connection failed")
        {
            StatusCode = StatusCodes.Status503ServiceUnavailable,
        };

        public static readonly ObjectResult TOKEN_TERMINATED = new("Token terminated")
        {
            StatusCode = StatusCodes.Status401Unauthorized,
        };
    }
}