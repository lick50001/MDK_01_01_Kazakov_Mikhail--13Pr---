using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Interface_Kazakov.Interfaces;
using Interface_Kazakov.Models;

namespace Interface_Kazakov.Classes
{
    public class UsersContext:Users, IUsers
    {
        public List<Users> AllUsers;

        public UsersContext() =>
            this.All(out AllUsers);

        public void All(out List<UsersContext> Users)
        {
            Users = new List<Users>();

            AllUsers.Add(new Users(1, "Аликина Ольга"));
            AllUsers.Add(new Users(2, "Бояркин Данил"));
            AllUsers.Add(new Users(3, "Бурмантов Владислав"));
            AllUsers.Add(new Users(4, "Дылдин Максим"));
            AllUsers.Add(new Users(5, "Евдокимов Даниил"));
            AllUsers.Add(new Users(6, "Костюнин Никита"));
            AllUsers.Add(new Users(7, "Кучин Данил"));
            AllUsers.Add(new Users(8, "Мотырев Александр"));
            AllUsers.Add(new Users(9, "Мухридинов Далер"));
            AllUsers.Add(new Users(10, "Олейник Владимир"));
            AllUsers.Add(new Users(11, "Саблин Константин"));
            AllUsers.Add(new Users(12, "Субботин Валерий"));
            AllUsers.Add(new Users(13, "Сукрушев Егор"));
            AllUsers.Add(new Users(14, "Торсунов Даниил"));
            AllUsers.Add(new Users(15, "Хабибрахманов Никита"));
            AllUsers.Add(new Users(16, "Хижматулин Григорий"));
            AllUsers.Add(new Users(17, "Черенев Сергей"));
            AllUsers.Add(new Users(18, "Чупин Дмитрий"));
            AllUsers.Add(new Users(19, "Шилов Дмитрий"));
        }
    }
}
