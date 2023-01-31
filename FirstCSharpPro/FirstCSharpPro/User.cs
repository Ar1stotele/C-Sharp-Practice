using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpPro
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; private set; }
        public string Password { get; set; }
        public double Amount { get; set; }
        public List<Car> UserCars { get; set; }

        public User() { }

        public User(int id, string userName, string password, double amount)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Amount = amount;
            UserCars = new List<Car>();
        }

        /*
         * In case of fail throws Exception
         */
        public void PurchaseCar(Car newCar)
        {
            Console.WriteLine("user - {0}, is willing to buy {1}.", UserName, newCar.Model);
            if (newCar.Price < Amount)
            {   
                if(UserCars != null) {        
                    for (int i = 0; i < UserCars.Count; i++)
                    {
                        if(newCar.Id == UserCars[i].Id)
                        {
                            throw new Exception("Car is already purchased");
                        }
                    }
                }
                if(newCar.isUsed)
                {
                    throw new Exception("Car is being used, cannot purchase at the moment");
                }

                Amount -= newCar.Price;
                UserCars.Add(newCar);
                Console.WriteLine("{0} has successfully bought {1} for {2}", UserName, newCar.Model, newCar.Price);
            } else
            {
                throw new Exception("Insufficient funds");
            }
        }

        public void ChangeUserName(string newUsername)
        {
            UserName = newUsername;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        public void RemoveCar(Car carToRemove)
        {
            UserCars.Remove(carToRemove);
        }

        public void OwnedCars()
        {
            for (int i = 0; i < UserCars.Count; i++)
            {
                UserCars[i].ShowCarInformation();
            }
        }

        public void ShowUserInformation()
        {
            Console.WriteLine("User Information: id - {0}, username - {1}, password - {2}, amount - {3}", Id, UserName, Password, Amount);
        }

    }
}
