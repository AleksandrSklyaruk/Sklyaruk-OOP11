using Model;
using System;
using System.Reflection;

namespace lb1
{
    class Program
    {
        // Точка входа в программу. Это первая функция, которая выполняется.
        static void Main(string[] args)
        {
            //  Создание программно дух списков персон,
            //  в каждом из которых будет по три человека
            Console.WriteLine("Шаг a: Создание двух списков по три человека.");
            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            // Добавляем трёх людей в каждый список.
            list1.Add(new Person("Иван", "Иванов", 25, Gender.Male));
            list1.Add(new Person("Анна", "Петрова", 30, Gender.Female));
            list1.Add(new Person("Сергей", "Сидоров", 35, Gender.Male));

            list2.Add(new Person("Мария", "Кузнецова", 28, Gender.Female));
            list2.Add(new Person("Дмитрий", "Смирнов", 40, Gender.Male));
            list2.Add(new Person("Елена", "Васильева", 22, Gender.Female));

            Console.WriteLine("Списки созданы.");
            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            // b. Выведите содержимое каждого списка на экран с соответствующими подписями списков.
            Console.WriteLine("\nШаг b: Вывод содержимого списков.");
            Console.WriteLine("Список 1:");
            for (int i = 0; i < list1.Count; i++)
            {
                Person person = list1.Get(i);
                Console.WriteLine($" " +
                    $" {i + 1}. {person.Name} {person.Surname}, " +
                    $"возраст: {person.Age}, " +
                    $"пол: {(person.Gender)}");
            }

            Console.WriteLine("\nСписок 2:");
            for (int i = 0; i < list2.Count; i++)
            {
                Person person = list2.Get(i);
                Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}, " +
                    $"возраст: {person.Age}, " +
                    $"пол: {(person.Gender)}");
            }

            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            // c. Добавьте нового человека в первый список.
            Console.WriteLine("\nШаг c: Добавление нового человека в первый список.");
            Person newPerson = new Person("Ольга", "Морозова", 27, Gender.Female);
            list1.Add(newPerson);
            Console.WriteLine($"Добавлен человек: {newPerson.Name} {newPerson.Surname}");

            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            // d. Скопируйте второго человека из первого списка в конец второго списка.
            // Покажите, что один и тот же человек находится в обоих списках.
            Console.WriteLine("\nШаг d: Копирование второго человека из первого списка во второй.");
            // Получаем второго человека из первого списка (индекс 1, потому что индексация с 0).
            Person secondPersonFromList1 = list1.Get(1);
            list2.Add(secondPersonFromList1); // Добавляем его во второй список.

            Console.WriteLine($"Скопирован человек: {secondPersonFromList1.Name} {secondPersonFromList1.Surname}");
            Console.WriteLine("Проверка: один и тот же человек находится в обоих списках.");

            Console.WriteLine("Список 1 (после копирования):");
            for (int i = 0; i < list1.Count; i++)
            {
                Person person = list1.Get(i);
                Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}," +
                    $" возраст: {person.Age}," +
                    $" пол: {(person.Gender)}");
            }

            Console.WriteLine("\nСписок 2 (после копирования):");
            for (int i = 0; i < list2.Count; i++)
            {
                Person person = list2.Get(i);
                Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}," +
                    $" возраст: {person.Age}," +
                    $" пол: {(person.Gender)}");
            }

            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            // e. Удалите второго человека из первого списка. Покажите, что удаление человека из первого списка не привело к уничтожению этого же человека во втором списке.
            Console.WriteLine("\nШаг e: Удаление второго человека из первого списка.");
            list1.RemoveAt(1); // Удаляем элемент с индексом 1 (второй элемент).
            Console.WriteLine("Второй человек удален из первого списка.");

            Console.WriteLine("Список 1 (после удаления):");
            for (int i = 0; i < list1.Count; i++)
            {
                Person person = list1.Get(i);
                Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}," +
                    $" возраст: {person.Age}," +
                    $" пол: {(person.Gender)}");
            }

            Console.WriteLine("\nСписок 2 (после удаления из первого списка):");
            for (int i = 0; i < list2.Count; i++)
            {
                Person person = list2.Get(i);
                Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}," +
                    $" возраст: {person.Age}," +
                    $" пол: {(person.Gender)}");
            }

            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            // f. Очистите второй список.
            Console.WriteLine("\nШаг f: Очистка второго списка.");
            list2.Clear();
            Console.WriteLine("Второй список очищен.");

            Console.WriteLine("Список 2 (после очистки):");
            if (list2.Count == 0)
            {
                Console.WriteLine("  Список пуст.");
            }
            else
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    Person person = list2.Get(i);
                    Console.WriteLine($"  {i + 1}. {person.Name} {person.Surname}," +
                        $" возраст: {person.Age}," +
                        $" пол: {(person.Gender)}");
                }
            }

            Console.ReadKey(); // Ожидаем нажатия любой клавиши.

            Console.WriteLine("\nПрограмма завершена.");
            Console.ReadLine();
        }
    }
}
