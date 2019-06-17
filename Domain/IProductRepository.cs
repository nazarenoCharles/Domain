using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    public interface IProductRepository
    { 
        void Add(Product product); //Add Product
        void Update(Product product); // Update Product
        void Search(Guid uID); // Search Product
        void Delete(Product product); // Delete Product
    }
}
