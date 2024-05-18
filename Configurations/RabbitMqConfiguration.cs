namespace Configurations
{
    public static class RabbitMqConfiguration
    {
        
        public static string RmqUri { get;  } = string.Concat("rabbitmq://", Environment.GetEnvironmentVariable("RABBITMQ") ?? "localhost");
        public static string Queue { get; } = Environment.GetEnvironmentVariable("QUEUENAME") ?? "rabbitQueue";
        public static  string QueueUrl { get; } = string.Concat(RmqUri, "/", Queue);

        public static  string UserName => Environment.GetEnvironmentVariable("RMQUSERNAME") ?? "guest";
        public static  string Password => Environment.GetEnvironmentVariable("RMQPASSWORD") ?? "guest";

    }
}