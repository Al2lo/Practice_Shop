namespace PracticeShop.BLL.Configuration
{
    public class JwtOptions
    {
        public string SecretKeyAccess { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;

    }
}