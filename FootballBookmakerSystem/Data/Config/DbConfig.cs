namespace P02_FootballBetting.Data.Config;

using Microsoft.Extensions.Configuration;

public static class DbConfig
{
    public static string ReadSettings()
    {
        ConfigurationBuilder builder = new ConfigurationBuilder();

        builder
            .AddJsonFile("usersecrets.json")
            .AddUserSecrets<StartUp>();

        IConfigurationRoot configurationRoot = builder.Build();

        return configurationRoot.GetConnectionString("ConnectionString");
    }
}
