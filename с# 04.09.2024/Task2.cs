using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace с__04._09._2024
{
    class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Имя животного: {name}, Возраст животного {age}");
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ age.GetHashCode();
        }
    }
    class Tiger : Animal
    {
        public int speed { get; set; }
        public Tiger(int speed, string name, int age) : base(name, age) { this.speed = speed; }
        public override void Info()
        {
            Console.WriteLine($"Имя животного: {name}, Возраст: {age}, Скорость: {speed} км/ч");
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ age.GetHashCode();
        }
    }
    class Crocodile : Animal
    {
        public int length { get; set; }
        public Crocodile(int length, string name, int age) : base(name, age) { this.length = length; }
        public override void Info()
        {
            Console.WriteLine($"Имя животного: {name}, Возраст: {age}, Размер: {length} см");
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ age.GetHashCode();
        }
    }
    class Kangaroo : Animal
    {
        public int jumpHeight { get; set; }
        public Kangaroo(int jumpHeight, string name, int age) : base(name, age) { this.jumpHeight = jumpHeight; }
        public override void Info()
        {
            Console.WriteLine($"Имя животного: {name}, Возраст: {age} лет, Высота прыжка: {jumpHeight} метров");
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ age.GetHashCode();
        }
    }

}


