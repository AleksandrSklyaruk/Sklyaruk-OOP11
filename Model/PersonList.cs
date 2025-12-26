using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonList
    {
        private List<Person> _persons = new List<Person>();

        /// <summary>
        /// Добавляет нового человека в список
        /// </summary>
        public void Add(Person person)
        {
            _persons.Add(person);
        }

        /// <summary>
        /// Удаляет указанного человека из списка
        /// </summary>
        public void Remove(Person person)
        {
            _persons.Remove(person);
        }

        /// <summary>
        /// Удаляет человека из списка по его индексу
        /// </summary>
        public void RemoveAt(int index)
        {
            _persons.RemoveAt(index);
        }

        /// <summary>
        /// Возвращает человека из списка по его индексу
        /// </summary>
        public Person Get(int index)
        {
            return _persons[index];
        }

        /// <summary>
        /// Возвращает индекс указанного человека в списке
        /// Если человек не найден, возвращает -1
        /// </summary>
        public int IndexOf(Person person)
        {
            return _persons.IndexOf(person);
        }

        /// <summary>
        /// Очищает список, удаляя всех людей
        /// </summary>
        public void Clear()
        {
            _persons.Clear();
        }

        /// <summary>
        /// Возвращает количество людей в списке
        /// </summary>
        public int Count
        {
            get { return _persons.Count; }
        }
    }
}
