using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace с__04._09._2024
{
    class Product
    {
        public string name { get; set; }
        public string nameOfPlace { get; set; }
        public float price { get; set; }
        public Product(string name, string nameOfPlace, int price)
        {
            this.name = name;
            this.nameOfPlace = nameOfPlace;
            this.price = price;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Товар: {name}, Место продажи: {nameOfPlace}, Цена: {price} грн");
        }
        public virtual decimal GetHashCode()
        {
            return name.GetHashCode() ^ nameOfPlace.GetHashCode() ^ price.GetHashCode();
        }
    }
    class Toy : Product
    {
        public string years { get; set; }
        public string Place { get; set; }
        public Toy(string name, string nameOfPlace, int price, string years, string Place) : base(name, nameOfPlace, price)
        {
            this.years = years;
            this.Place = Place;
        }
        public override void Info()
        {
            Console.WriteLine($"Товар: {name}");
            Console.WriteLine($"Место продажи: {nameOfPlace}");
            Console.WriteLine($"Цена: {price} грн");
            Console.WriteLine($"Возрастная категория: {years}");
            Console.WriteLine($"Место изготовления: {Place}");
        }
        public override decimal GetHashCode()
        {
            return name.GetHashCode() ^ nameOfPlace.GetHashCode() ^ price.GetHashCode() ^ years.GetHashCode() ^ Place.GetHashCode();
        }
    }
}

