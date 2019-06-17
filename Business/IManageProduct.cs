namespace Business
{
    public interface IManageProduct
    {
        bool NewProduct(string prodName, double prodPrice);
        bool UpdateProduct(string prodName, double prodPrice);
    }
}