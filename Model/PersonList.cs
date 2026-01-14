using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс списка с людьми
    /// </summary>
    public class PersonList
    {
        private List<Person> _persons = new List<Person>();

        /// <summary>
        /// Добавить нового человека в список
        /// </summary>
        public void Add(Person person)
        {
            _persons.Add(person);
        }

        /// <summary>
        /// Удалить указанного человека из списка
        /// </summary>
        public void Remove(Person person)
        {
            _persons.Remove(person);
        }

        /// <summary>
        /// Удалить человека из списка по его индексу
        /// </summary>
        public void RemoveAt(int index)
        {
            _persons.RemoveAt(index);
        }

        /// <summary>
        /// Вернуть человека из списка по его индексу
        /// </summary>
        public Person Get(int index)
        {
            return _persons[index];
        }

        /// <summary>
        /// Вернуть индекс указанного человека в списке
        /// Если человек не найден, вернуть -1
        /// </summary>
        public int IndexOf(Person person)
        {
            return _persons.IndexOf(person);
        }

        /// <summary>
        /// Очистить список, удалив всех людей
        /// </summary>
        public void Clear()
        {
            _persons.Clear();
        }

        /// <summary>
        /// Вернуть количество людей в списке
        /// </summary>
        public int Count
        {
            get { return _persons.Count; }
        }
    }
}
