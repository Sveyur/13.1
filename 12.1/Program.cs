using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Краснодар", 100, 50, 15);
            MyltiBuilding myltiBuilding = new MyltiBuilding("Ялта", 6, 10, 5,5);
            building.Print();
            Console.WriteLine();
            myltiBuilding.Print();
            myltiBuilding.Printer();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Building()
        {
          
        }
        public Building(string address, float length, float width, float heigth)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = heigth;
        }
        public void Print()
        {
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Длина здания: " + Length);
            Console.WriteLine("Ширина здания: " + Width);
            Console.WriteLine("Высота здания: " + Height);
        }

    }
    sealed class MyltiBuilding : Building
    {
        private int Floot { get; set; }
        
        public MyltiBuilding(string address, float length, float width, float heigth,int floot)
            : base(address, length, width, heigth)
        {
            Floot = floot;
        }
        public void Printer()
        {
            Console.WriteLine("Этажей: " + Floot);
        }


    }
}
