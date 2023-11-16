using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cat
    {
        private int hungerLevel; // Уровень голода

        public Cat()
        {
            hungerLevel = 0; // Начальный уровень голода
        }

        public void Eat(Food food)
        {
            switch (food)
            {
                case Food.Fish:
                    hungerLevel += 3; // Уровень голода уменьшается на 3 после съедения рыбы
                    break;
                case Food.Mouse:
                    hungerLevel += 2; // Уровень голода уменьшается на 2 после съедения мыши
                    break;
                case Food.Milk:
                    hungerLevel += 1; // Уровень голода уменьшается на 1 после выпития молока
                    break;
                default:
                    Console.WriteLine("Неизвестная еда");
                    break;
            }
        }

        public int HungerLevel
        {
            get { return hungerLevel; }
        }
    }
}
