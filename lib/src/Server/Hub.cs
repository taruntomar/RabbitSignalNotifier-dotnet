using System;
using RabbitMQ.Client;


namespace Notifier.Server
{
    public class Hub
    {
        public IRabbitMQConfig RabbitMQConfig { get; set; }
        public IHubConfig HostConfig { set; get; }
        public Hub(IRabbitMQConfig rabbitMQConfig, IHubConfig hostConfig)
        {
            this.RabbitMQConfig = rabbitMQConfig;
            this.HostConfig = hostConfig;
        }


        public void Start()
        {
            ConnectionFactory factory = new ConnectionFactory() { Uri = RabbitMQConfig.Uri };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "hello",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();

        }
        public void Shutdown()
        {

        }



    }
}