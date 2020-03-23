using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace steeltoetest.Options
{
    public class SquidProxyServiceOption : AbstractServiceOptions
    {
        public SquidProxyServiceOption() { }

        public string Instance_name { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string Plan { get; set; }
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