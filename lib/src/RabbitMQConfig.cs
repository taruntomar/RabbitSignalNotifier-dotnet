using System;

namespace Notifier
{

     public class RabbitMQConfig
     {
        string Host{ set; get;}
        string Port {set; get;}
        string User {set; get;}
        string Password {set; get;}

        string VirtualHost {get; set;}

        string Uri{get {return $@"amqp://{User}:{Password}@{Host}:{Port}/{VirtualHost}";}}

     }
}