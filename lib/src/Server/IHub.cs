using System;

namespace Notifier.Server
{

    public interface IHub
    {
         IRabbitMQConfig RabbitMQConfig {get; set;}
         IHubConfig HostConfig {get; set;}

         void Start();
         void Shutdown();


    }

}