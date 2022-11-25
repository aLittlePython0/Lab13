using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vehicle
    {
        protected string Name { get; set; }
        protected int PassangersMin { get; set; }
        protected int PassangersMax { get; set; }
        protected int SpeedMax { get; set; }
        protected int Price { get; set; }
        public virtual void GetInfo() { }
    }

    class Plane : Vehicle
    {
        public Plane() { }
        public Plane(string Name, int PassangersMin, int PassangersMax, int SpeedMax)
        {
            this.Name = Name;
            this.PassangersMin = PassangersMin;
            this.PassangersMax = PassangersMax;
            this.SpeedMax = SpeedMax;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}, Passangers Min: {PassangersMin}, Passangers Max: {PassangersMax}, Speed: {SpeedMax} km/h\n");
        }
    }

    class PassengerPlane : Plane
    {
        public PassengerPlane(string Name, int PassangersMin, int PassangersMax, int SpeedMax, int Price)
        {
            this.Name = Name;
            this.PassangersMin = PassangersMin;
            this.PassangersMax = PassangersMax;
            this.SpeedMax = SpeedMax;
            this.Price = Price;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}, Passangers Min: {PassangersMin}, Passangers Max: {PassangersMax}, Speed: {SpeedMax} km/h, Price: {Price} milion $\n");
        }
    }

    class MilitaryPlane : Plane
    {
        protected string Weapon { get; set; }
        public MilitaryPlane(string Name, int PassangersMax, int SpeedMax, int Price, string Weapon)
        {
            this.Name = Name;
            this.PassangersMax = PassangersMax;
            this.SpeedMax = SpeedMax;
            this.Price = Price;
            this.Weapon = Weapon;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}, Crew: {PassangersMax}, Speed Max: {SpeedMax} km/h, Price: {Price} milion $,\nWeapon:{Weapon}\n");
        }
    }


    class TransportPlane : Plane
    {
        public TransportPlane(string Name, int PassangersMin, int PassangersMax, int SpeedMax, int Price)
        {
            this.Name = Name;
            this.PassangersMin = PassangersMin;
            this.PassangersMax = PassangersMax;
            this.SpeedMax = SpeedMax;
            this.Price = Price;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name}, Passangers Min: {PassangersMin}, Passangers Max: {PassangersMax}, Speed Max: {SpeedMax} km/h, Price: {Price} milion $\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vehicle s = new Plane("Plane", 1, 2000, 11230);
            s.GetInfo();

            Plane[] A = new Plane[3];
            PassengerPlane B = new PassengerPlane("Airbus A380", 525, 853, 903, 360);
            MilitaryPlane C = new MilitaryPlane("F-22 Raptor", 1, 2414, 379, "gun M61A2 Vulcan, Air-to-air missiles,JDAM guided bombs ");
            TransportPlane D = new TransportPlane("An - 225 Mriya", 6, 70, 850, 800);
            A[0] = B;
            A[1] = C;
            A[2] = D;

            for (int i = 0; i < 3; i++)
            {
                A[i].GetInfo();
            }

        }
    }


}