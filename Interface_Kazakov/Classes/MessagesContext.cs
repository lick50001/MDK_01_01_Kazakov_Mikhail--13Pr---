using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Interface_Kazakov.Interfaces;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Classes
{
    public class MessagesContext: Messages, IMessages
    {
        public static List<Messages> AllMessages;
        public MessagesContext() => AllMessages(out AllMessages);

        public MessagesContext(string Messages, DateTime Create, int IdUsers) { }

        public void All(out List<Messages> Messages) =>
            Messages = new List<Messages>();

        public void Deelte() =>
            AllMessages.Remove(this);
        
        public void Save(bool Update = false)
        {
            if (Update == false)
                AllMessages.Add(this);
        }
    }
}
