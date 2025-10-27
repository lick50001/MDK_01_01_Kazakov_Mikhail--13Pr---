using System;
using System.Collections.Generic;
using System.Linq;
using Interface_Kazakov.Interfaces;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Classes
{
    // Класс НЕ наследует Messages — он работает с ними
    public class MessagesContext 
    {
        public static List<Messages> AllMessages { get; } = new List<Messages>();

        public string MessageText { get; set; }
        public DateTime Create { get; set; }
        public int IdUser { get; set; }
        public string Message { get; internal set; }

        public MessagesContext() { }

        public MessagesContext(string messageText, DateTime create, int idUser)
        {
            MessageText = messageText;
            Create = create;
            IdUser = idUser;
        }

        public void All(out List<Messages> messages)
        {
            messages = new List<Messages>(AllMessages);
        }

        public void Delete(int id)
        {
            var msg = AllMessages.FirstOrDefault(m => m.Id == id);
            if (msg != null)
                AllMessages.Remove(msg);
        }

        public void Save(string messageText, DateTime create, int idUser)
        {
            int newId = AllMessages.Count == 0 ? 1 : AllMessages.Max(m => m.Id) + 1;
            AllMessages.Add(new Messages(messageText, create, idUser) { Id = newId });
        }

        public List<Messages> GetMessagesByUser(int userId)
        {
            return AllMessages.Where(m => m.IdUser == userId).ToList();
        }
    }
}