using System;

namespace Notifier
{

     public interface IRabbitMQConfig
     {
        string Host{ set; get;}
        string Port {set; get;}
        string User {set; get;}
        string Password {set; get;}

        string VirtualHost {get; set;}

        string Uri{get;}

     }
}