namespace ObjectPoolPattern
{
    using System;

    public class Car : IDisposable
    {
        private readonly DateTime rentedAt = DateTime.Now;

        public DateTime RentedAt
        {
            get { return this.rentedAt; }
        }

        public int? CustomerID { get; set; }

        public void Dispose()
        {
            this.CustomerID = null;
        }
    }
}
