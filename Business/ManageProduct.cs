using System;
using Domain;
namespace Business
{
    public class ManageProduct : IManageProduct
    {
        public bool NewProduct(string prodName, double prodPrice)
        {
            if (string.IsNullOrEmpty(prodName) || double.IsNegative(prodPrice))
            {
                return false;
            }
            if (prodName.Length < 20)
            {
                return false;
            }
            return true;
        }
        public bool UpdateProduct(string prodName, double prodPrice)
        {
            if (string.IsNullOrEmpty(prodName) || double.IsNegative(prodPrice))
            {
                return false;
            }
            return true;
        }

    }
}
