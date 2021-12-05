using System;

namespace SPZ_Lab6.Model
{
    class Occupant
    {
        public string OccupantLastName { get; set; }
        public string OccupantFirstName { get; set; }
        public int Days { get; set; }
        private static string[] lastNamesArray = new string[] { "Бондаренко", "Петренко", "Шевченко", "Носик", "Токарь",
                                                                 "Кротенко", "Рыженко", "Зубенко", "Чепурных", "Титаренко",
                                                                  "Нотич", "Стадник", "Смит", "Грей", "Паркер", "Скотт"};
        private static string[] firstNamesArray = new string[] { "Александр","Максим", "Даниил", "Иван", "Сергей", "Адам",
                                                                 "Михаил", "Карл","Кристиан", "Джон", "Лукас","Кристиан",
                                                                  "Ольга", "Оливия", "Мария", "Анна", "Татьяна",
                                                                  "Алиса", "Ева", "Полина", "Сабрина", "Хлоя", "Эшли"};
        static Random random = new Random();
        public Occupant()
        {
            OccupantLastName = lastNamesArray[random.Next(0, lastNamesArray.Length)];
            OccupantFirstName = firstNamesArray[random.Next(0, firstNamesArray.Length)];
            Days = random.Next(1, 5);
        }
        public Occupant(string lastName, string firstName, int days)
        {
            OccupantLastName = lastName;
            OccupantFirstName = firstName;
            Days = days;
        }
    }
}
