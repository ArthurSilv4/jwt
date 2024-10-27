using DotNetEnv;

namespace jwt
{
    public class Configuration
    {
        public static string PrivateKey { get; set; }

        static Configuration()
        {
            Env.Load();

            PrivateKey = Environment.GetEnvironmentVariable("PRIVATE_KEY") ?? string.Empty;
        }
    }
}
