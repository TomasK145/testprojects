using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRExample
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {        
            //https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr
            Clients.All.broadcastMessage(name, message);
        }
    }
}