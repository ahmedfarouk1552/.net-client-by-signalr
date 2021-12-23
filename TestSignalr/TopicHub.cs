using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestSignalr.Models;

namespace TestSignalr
{
    [HubName("topic")]
    public class TopicHub : Hub
    {
        ITIContext db = new ITIContext();
        public void addtopic(int top_id,string top_name)
        {
            Topic t = new Topic() { Top_Id = top_id, Top_Name = top_name };
            db.Topics.Add(t);
            db.SaveChanges();
            Clients.All.newtopic(top_id, top_name);
        }
    }
}