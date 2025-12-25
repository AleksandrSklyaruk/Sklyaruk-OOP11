using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;
        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;
        /// <summary>
        /// Пол
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Свойство Name позволяет получить или установить имя человека.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"{nameof(Name)} can't be null or empty!");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Свойство Surname позволяет получить или установить фамилию человека.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"{nameof(Surname)} can't be null or empty!");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Свойство Age позволяет получить или установить возраст человека.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                const int minAge = 0;
                const int maxAge = 123;
                if (value < minAge || value > maxAge)
                {
                    throw new Exception($"{nameof(Age)} can't be less {minAge} or above {maxAge}!");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Свойство Gender позволяет получить или установить пол человека.
        /// </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = Gender.Male;
        }

        public Person() : this("Ivan", "Ivanov", 18)
        {

        }
    }
}
