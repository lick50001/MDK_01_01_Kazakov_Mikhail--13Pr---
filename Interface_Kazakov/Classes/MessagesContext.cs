using System;
using System.Collections.Generic;
using System.Linq;
using Interface_Kazakov.Interfaces;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Classes
{
    // Класс НЕ наследует Messages — он работает с ними
    public class MessagesContext : IMessages
    {
        // Статическое поле — инициализируем сразу, чтобы избежать null
        public static List<Messages> AllMessages { get; } = new List<Messages>();

        public string MessageText { get; set; }
        public DateTime Create { get; set; }
        public int IdUser { get; set; }

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

        public void Delete()
        {
            var toRemove = AllMessages.FirstOrDefault(m =>
                m.Message == MessageText &&
                m.Create == Create &&
                m.IdUser == IdUser);

            if (toRemove != null)
                AllMessages.Remove(toRemove);
        }

        public void Save(bool Update = false)
        {
            if (!Update)
            {
                int newId = AllMessages.Count == 0 ? 1 : AllMessages.Max(m => m.Id) + 1;

                var newMessage = new Messages
                {
                    Id = newId,
                    Message = MessageText,
                    Create = Create,
                    IdUser = IdUser
                };

                AllMessages.Add(newMessage);
            }
        }
    }
}