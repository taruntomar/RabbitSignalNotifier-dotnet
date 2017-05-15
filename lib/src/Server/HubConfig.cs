using System;

namespace Notifier.Server{

public class HubConfig:IHubConfig
{
    public string HubName {set; get;}
    public string HubQueueName {get{ return "Notifier-Hub-"+HubName+"-Queue"; }}
    
}

}