using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Описати базовий клас (можливо, абстрактний), у якому за допомогою
віртуальних або абстрактних методів та властивостей задається інтерфейс для
похідних класів.
В усіх класах потрібно перевизначити метод Equals, щоби порівнювались
значення, а не посилання. Визначити в класах усі можливі конструктори.
Метод Main повинен утримувати масив або список з елементів базового
класу, заповнений посиланнями на похідні класи, та демонструвати
використання усіх розроблених елементів класів відповідно варіанту.
Показати на прикладі одного з методів, присутніх у кожному класі,
використання поліморфізму.
Обов’язково продемонструвати різницю між раннім та пізнім зв’язуванням

1. Квіткарка. Визначити ієрархію квітів. Створити кілька об'єктів-квітів.
Зібрати букет з визначенням його вартості.*/

namespace Lab13
{
    class Flowers
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Flowers(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public virtual void Display()
        {
            Console.WriteLine($"{Name} {Color}");
        }
    }
    class Rose : Flowers
    {
        public string Therapeutic_Properties { get; set; }
        public Rose(string name, string color, string therapeutic_properties) : base(name, color)
        {
            Therapeutic_Properties = therapeutic_properties;
        }
        public override void Display()
        {
            Console.WriteLine
            ($"{Name} {Color} {Therapeutic_Properties}");
        }
    }
    class Tupil : Flowers
    {
        public string Season { get; set; }
        public Tupil(string name, string color, string season) : base(name, color)
        {
            Season = season;
        }
        public override void Display()
        {
            Console.WriteLine
            ($"{Name} {Color} {Season}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Flowers p1 = new Flowers("name", "color");
            p1.Display();
            Rose p2 = new Rose("rose", "red", "disinfection of wounds");
            p2.Display();
            Tupil p3 = new Tupil("tupil", "yellow", "summer");
            p3.Display();
        }
    }
}
