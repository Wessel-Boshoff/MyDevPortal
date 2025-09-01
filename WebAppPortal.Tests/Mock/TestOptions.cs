using Microsoft.Extensions.Options;
using WebAppPortalApi.Common.Options;


namespace WebAppPortal.Tests.Mock
{
    public static class TestOptions
    {

        public static IOptionsMonitor<JwtTokenOptions> JwtTokenOptions()
        {
            var options = new JwtTokenOptions
            {
                Issuer = "WebAppPortalApi",
                Audience = "ApplicationUsers",
                SecretKey = "ZpX5uE9sY3L2cN8tR4jV7wB1qH6dK0fM3aU9oP6yX2sT8gR1vL4jN7bC5zW8mQ2h",
                ExpirationMinutes = 30
            };

            return new OptionsMonitorStub<JwtTokenOptions>(options);
        }
    }

    class OptionsMonitorStub<T> : IOptionsMonitor<T>
    {
        private readonly T _currentValue;
        public OptionsMonitorStub(T currentValue) => _currentValue = currentValue;

        public T CurrentValue => _currentValue;
        public T Get(string name) => _currentValue;
        public IDisposable OnChange(Action<T, string> listener) => null;

    }
}
