namespace ObjectPoolPattern
{
    using System;
    using System.Threading;

    public static class ObjectPoolPatternDemo
    {
        public static void Main()
        {
            var rentalCompany = new RentalCompany<Car>();

            var car1 = rentalCompany.RentCar();
            car1.CustomerID = 58;
            Console.WriteLine(
                "Car 1 rented on {0:MM/dd/yyyy hh:mm:ss.fff tt} by {1}",
                car1.RentedAt,
                car1.CustomerID);
            Thread.Sleep(2000);

            var car2 = rentalCompany.RentCar();
            car2.CustomerID = 40;
            Console.WriteLine(
                "Car 2 rented on {0:MM/dd/yyyy hh:mm:ss.fff tt} by {1}",
                car2.RentedAt,
                car2.CustomerID);
            Thread.Sleep(2000);

            var car3 = rentalCompany.RentCar();
            car3.CustomerID = 66;
            Console.WriteLine(
                "Car 3 rented on {0:MM/dd/yyyy hh:mm:ss.fff tt} by {1}",
                car3.RentedAt,
                car3.CustomerID);
            Thread.Sleep(2000);

            //// rentalCompany.FreeCar(car1);

            try
            {
                var car4 = rentalCompany.RentCar();
                car4.CustomerID = 66;
                Console.WriteLine(
                    "Car 4 rented on {0:MM/dd/yyyy hh:mm:ss.fff tt} by {1}",
                    car4.RentedAt,
                    car4.CustomerID);
                Thread.Sleep(2000);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}