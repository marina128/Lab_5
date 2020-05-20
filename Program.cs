using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        /// <summary>
        /// Абстрактный класс предмета для открыия двери
        /// </summary>
        public abstract class Subject
        {
            /// <summary>
            /// Метод для открытия двери
            /// </summary>
            public abstract void open_the_door();
        }

        /// <summary>
        /// Класс ключа
        /// </summary>
        public class Key : Subject
        {
            public override void open_the_door()
            {
                Console.WriteLine("The door is open.");
            }
        }

        /// <summary>
        /// Класс отмычки
        /// </summary>
        public class MasterKey : Subject
        {
            public override void open_the_door()
            {
                Console.WriteLine("The door is open.");
            }
        }

        /// <summary>
        /// Класс для остальных предметов, не выполняющих никакого действия
        /// </summary>
        public class NullSubject : Subject
        {
            public override void open_the_door()
            {
                // doing nothing
            }
        }

        static void Main(string[] args)
        {
            string name;
            Subject sub;
            try
            {
                Console.WriteLine("Введите приспособление для открытия двери:");
                name = Console.ReadLine();
                switch (name.ToLower())
                {
                    case "ключ":
                        sub = new Key();
                        break;
                    case "отмычка":
                        sub = new MasterKey();
                        break;
                    default:
                        sub = new NullSubject();
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Неверно введены данные!");
            }
            Console.ReadLine();
        }
    }
}
