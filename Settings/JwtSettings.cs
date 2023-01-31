namespace BaseAuthenticationWebAPI.Settings
{
    public class JwtSettings
    {
        public string Key { get; set; } = string.Empty;
        public int ExpiredMinutes { get; set; }
    }
}
