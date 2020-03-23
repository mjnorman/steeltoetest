using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace steeltoetest.Options
{
    public class SquidProxyServiceOption : AbstractServiceOptions
    {
        public SquidProxyServiceOption() { }

        public SquidProxyCredentials Credentials { get; set; }
    }

    public class SquidProxyCredentials
    {
        public string Host { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string Uri { get; set; }
        public string Username { get; set; }

    }
}