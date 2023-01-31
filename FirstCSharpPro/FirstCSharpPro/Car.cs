using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpPro
{
    public class Car
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public bool isUsed { get; set; }

        public Car() { }

        public Car(int id, double price, string model) {
            Id = id;
            Price = price;
            Model = model;
        }

        public void ShowCarInformation(int indexOfCar = 1)
        {
            Console.WriteLine("{0}) Car Info: Model - {1}, Price - {2}$, id {3}",indexOfCar, Model, Price, Id);
        }

    // ~Car() { }


}
}
