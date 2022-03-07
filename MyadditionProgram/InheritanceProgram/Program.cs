using System;
namespace Inheritance
{
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void CarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price" + price);

        }
       
    }
    class Maruti:Car
    {
        float mileage;
        public void Mileage()
        {
          Console.WriteLine("Mileage:" + mileage);
        }
    
        static void Main(string[] args)
        {
            Maruti myCar = new Maruti();
            myCar.model="Ford";
            myCar.color="Blue" ;
            myCar.price = 4999990;
            myCar.mileage = 12.5f;
            myCar.CarInformation();
            myCar.Mileage();
            Console.ReadLine();


            
        }
    }
}