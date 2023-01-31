namespace FirstCSharpPro
{
    class program
    {
        static void Main(string[] args)
        {
            // random numbers generator
            Random rnd = new Random();

            var mustang = new Car(rnd.Next(), 6800.99, "Mustang");
            var audi = new Car(rnd.Next(), 18000.59, "Baunti");
            var bmw = new Car(rnd.Next(), 8000.99, "BMW");
            var mercedes = new Car(rnd.Next(), 1200.99, "Mercedes");

            List<Car> cars = new List<Car>();
            cars.Add(audi);
            cars.Add(bmw);
            cars.Add(mercedes);
            cars.Add(mustang);

            var userChoice = "";

            List<User> users = new List<User>();


            int CheckIfUserIsRegistered(string username, string password)
            {
                if(users.Count < 1) return -1;
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserName == username && users[i].Password == password)
                    {
                        return i;
                    }
                }
                return -1;
            }

            while(userChoice != "3")
            {
                
                Console.WriteLine("User choices:  1 - Login,  2 - Register, 3 - exit");
                userChoice = Console.ReadLine();
                
                if(userChoice == "1")
                {
                    Console.WriteLine("Enter your username");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    var password = Console.ReadLine();
                    var userIndex = CheckIfUserIsRegistered(username, password);
                    if (userIndex == -1)
                    {
                        Console.WriteLine("You have to be registered");
                        continue;
                    }
                    var loggedInUser = users[userIndex];
                    Console.WriteLine("You have logged in successfully user - {0}", loggedInUser.UserName);
                    Console.WriteLine("Enter on of the values from options: 0 - list all owned cars, 1 - list all car information, 2 - buy car, 3 - log out");

                    var loggedInUserChoice = "";
                    while (loggedInUserChoice != "3")
                    {
                        loggedInUserChoice = Console.ReadLine();

                        if (loggedInUserChoice == "0")
                        {
                            loggedInUser.OwnedCars();
                        }

                        if(loggedInUserChoice == "1")
                        {
                            for(int i = 0; i < cars.Count; i++)
                            {
                                cars[i].ShowCarInformation(i + 1);
                            }
                        }

                        if(loggedInUserChoice == "2")
                        {
                            Console.WriteLine("Which car would you like to buy? (Enter number of car)");
                            var indexOfSelectedCar = Convert.ToInt32(Console.ReadLine()) - 1;
                            try
                            {
                                loggedInUser.PurchaseCar(cars[indexOfSelectedCar]);
                                cars[indexOfSelectedCar].isUsed = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }

                if (userChoice == "2")
                {
                    Console.WriteLine("Registration form:");
                    Console.WriteLine("Enter your username");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter amount of money you have:");
                    var amount = Console.ReadLine();
                    users.Add(new User(rnd.Next(), username, password, Convert.ToDouble(amount)));
                    Console.WriteLine("You have successfully registered");
                }


                     
            }


        }

    }
}
