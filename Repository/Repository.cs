using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ProductRepository : IProductRepository

    {
        private readonly List<Product> productList = new List<Product>();
        
        public void Add(Product product)
        {
            productList.Add(product);
        }
        public void Search(Guid uID)
        {
            Product SearchResult = (Product)productList.Where(x => x.uID.Equals(uID));

        }
        public void Update(Product product)
        {
            foreach (var prod in productList)
            {
                if (prod.uID.Equals(product.uID))
                {
                    prod.ProductName = product.ProductName;
                    prod.ProductPrice = product.ProductPrice;
                }
            }
        }
        public void Delete(Product product)
        {
            foreach (var prod in productList)
            {
                if (prod.uID.Equals(product.uID))
                {
                    productList.Remove(prod);
                }
            }
        }


    }
}
