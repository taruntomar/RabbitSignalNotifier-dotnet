using System;

namespace Notifier.Server{

public interface IHubConfig
{
    string HubName {set; get;}
    string HubQueueName {get;}
    
}

}