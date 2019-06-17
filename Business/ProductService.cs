using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    public class ProductService
    {
        private readonly IManageProduct manageProduct;
        private readonly IProductRepository productRepository;

        public ProductService(IManageProduct manageProduct, IProductRepository productRepository)
        {
            this.manageProduct = manageProduct;
            this.productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            var isValid = this.manageProduct.NewProduct(product.ProductName, product.ProductPrice);
            if(!isValid)
            {
                throw new ArgumentException("Invalid Input!");
            }
            this.productRepository.Add(product);
        }
        public void UpdateProduct(Product product)
        {
            var checkUpdate = this.manageProduct.UpdateProduct(product.ProductName, product.ProductPrice);
            if(!checkUpdate)
            {
                throw new ArgumentException("Please check the fields!");
            }
            this.productRepository.Update(product);
        }
        public void SearchProduct(Guid uID)
        {
            this.productRepository.Search(uID);
        }
        public void DeleteProduct(Product product)
        {
            this.productRepository.Delete(product);
        }
        
    }
}
