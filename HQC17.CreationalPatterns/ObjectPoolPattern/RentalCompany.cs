namespace ObjectPoolPattern
{
    using System;
    using System.Collections.Generic;

    public class RentalCompany<T> where T : IDisposable, new()
    {
        private const int MaxCarsCount = 3;
        private readonly List<T> availableCars = new List<T>();
        private readonly List<T> rentedCars = new List<T>();

        // We can define the size of the pool in constructor
        public RentalCompany()
        {
        }

        public T RentCar()
        {
            lock (this.availableCars)
            {
                if (this.availableCars.Count != 0)
                {
                    var car = this.availableCars[0];
                    this.rentedCars.Add(car);
                    this.availableCars.RemoveAt(0);
                    return car;
                }
                else
                {
                    if (this.rentedCars.Count < MaxCarsCount)
                    {
                        var car = new T();
                        this.rentedCars.Add(car);
                        return car;
                    }
                    else
                    {
                        throw new InvalidOperationException("No more cars left...");
                    }
                }
            }
        }

        public void FreeCar(T car)
        {
            car.Dispose();

            lock (this.availableCars)
            {
                this.availableCars.Add(car);
                this.rentedCars.Remove(car);
            }
        }
    }
}
