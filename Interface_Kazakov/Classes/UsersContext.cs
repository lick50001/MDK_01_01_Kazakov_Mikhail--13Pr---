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
    public class UsersContext:IUsers
    {
        private readonly List<Users> _allUsers;

        public UsersContext()
        {
            _allUsers = new List<Users>
            {
                new Users(1, "Аликина Ольга"),
                new Users(2, "Бояркин Данил"),
                new Users(3, "Бурмантов Владислав"),
                new Users(4, "Дылдин Максим"),
                new Users(5, "Евдокимов Даниил"),
                new Users(6, "Костюнин Никита"),
                new Users(7, "Кучин Данил"),
                new Users(8, "Мотырев Александр"),
                new Users(9, "Мухридинов Далер"),
                new Users(10, "Олейник Владимир"),
                new Users(11, "Саблин Константин"),
                new Users(12, "Субботин Валерий"),
                new Users(13, "Сукрушев Егор"),
                new Users(14, "Торсунов Даниил"),
                new Users(15, "Хабибрахманов Никита"),
                new Users(16, "Хижматулин Григорий"),
                new Users(17, "Черенев Сергей"),
                new Users(18, "Чупин Дмитрий"),
                new Users(19, "Шилов Дмитрий")
            };
        }

        public void All(out List<Users> users)
        {
            users = new List<Users>(_allUsers);
        }
    }
}
