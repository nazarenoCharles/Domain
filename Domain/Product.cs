using System;

namespace Domain
{
    public class Product : IEntity
    {
        public Guid uID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

    }
}
