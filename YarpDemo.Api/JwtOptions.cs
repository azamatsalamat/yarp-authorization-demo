namespace YarpDemo.Api
{
    public class JwtOptions
    {
        public const string SectionName = "JwtSettings";
        public bool ValidateIssuerSigningKey { get; set; }
        public bool ValidateIssuer { get; set; }
        public string ValidIssuer { get; set; }
        public bool ValidateAudience { get; set; }
        public string ValidAudience { get; set; }
        public bool RequireExpirationTime { get; set; }
        public bool ValidateLifetime { get; set; }
        public int TokenExpires { get; set; }
        public string AccessTokenSecret { get; set; }
        public int RefreshTokenTTL { get; set; } = 604800; // 1 week
    }
}
