using Model;
using System;
using System.Reflection;

namespace lb1
{
    /// <summary>
    /// Класс основной части программы
    /// </summary>
    class Program
    {
        /// <summary>
        /// Создание списков
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            // Добавление трёх людей в каждый список
            list1.Add(new Person("Александр", "Склярук", 23, Gender.Male));  
            list1.Add(new Person("Араик", "Шароян", 24, Gender.Male));
            list1.Add(new Person("Андрей", "Доценко", 23, Gender.Male));

            list2.Add(new Person("Николай", "Казначеев", 25, Gender.Male));
            list2.Add(new Person("Роман", "Иванов", 30, Gender.Male));
            list2.Add(new Person("Анастасия", "Петрова", 48, Gender.Female));
            WaitForKey();

            // Вывод содержимого каждого списка
            PrintList(list1, "Список 1");
            PrintList(list2, "Список 2");
            WaitForKey();

            // Добавление нового человека в первый список
            Person newPerson = new Person("Валерия", "Андреева", 23, Gender.Female);
            list1.Add(newPerson);
            Console.WriteLine("\nПосле добавления нового человека в первый список:");
            PrintList(list1, "Список 1");
            WaitForKey();

            // Копирование второго человека из первого списка во второй список
            Person personCopy = list1.Get(1);
            list2.Add(personCopy);
            Console.WriteLine($"Скопирован человек: " +
                $"{personCopy.Name} {personCopy.Surname}");
            PrintList(list1, "Список 1 (после копирования)");
            PrintList(list2, "Список 2 (после копирования)");
            WaitForKey();

            // Удаление второго человека из первого списка
            list1.RemoveAt(1);
            Console.WriteLine("Второй человек удален из первого списка.");
            PrintList(list1, "Список 1 (после удаления)");
            PrintList(list2, "Список 2 (после удаления из первого списка)");
            WaitForKey();

            // Отчистка второго списка
            list2.Clear();
            Console.WriteLine("Второй список очищен.");
            PrintList(list2, "Список 2 (после очистки)");
            WaitForKey();

            // Ввод, добавление в список, вывод
            Console.WriteLine("\nДобавим человека вручную в Список 1:");
            Person personFromConsole = ReadFromConsole();
            list1.Add(personFromConsole);
            Console.WriteLine("\nВ Список 1 добавлен человек:");
            PrintPerson(personFromConsole);
            PrintList(list1, "Список 1 после добавления");
            WaitForKey();
        }

        /// <summary>
        /// Метод для вывода списка людей на консоль с указанным заголовком
        /// </summary>
        /// <param name="list">Список для вывода</param>
        /// <param name="listName">Заголовок списка</param>
        private static void PrintList(PersonList list, string listName)
        {
            Console.WriteLine($"\n{listName}:");
            for (int i = 0; i < list.Count; i++)
            {
                PrintPerson(list.Get(i));
            }
        }

        /// <summary>
        /// Метод для вывода информации об одном человеке
        /// </summary>
        /// <param name="person">Объект Person для вывода</param>
        private static void PrintPerson(Person person)
        {
            string genderStr = person.Gender 
                == Gender.Male ? "Мужской" : "Женский";
            Console.WriteLine($"{person.Name} {person.Surname}," +
                $" возраст: {person.Age}, пол: {genderStr}");
        }

        /// <summary>
        /// Метод для паузы между пунктами программы
        /// </summary>
        private static void WaitForKey()
        {
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }

        /// <summary>
        /// Считывает данные о человеке с консоли
        /// </summary>
        /// <returns>Новый экземпляр класса <see cref="Person"/>.</returns>
        private static Person ReadFromConsole()
        {
            Console.Write("Имя: ");
            string name = Console.ReadLine()!;

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine()!;

            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine()!);

            Console.Write("Пол (0 = мужской, 1 = женский): ");
            int genderInput = int.Parse(Console.ReadLine()!);
            Gender gender = (Gender)genderInput;

            return new Person(name, surname, age, gender);
        }
    }
}
