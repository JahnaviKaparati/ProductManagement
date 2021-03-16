using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Services
{
    public interface ICustomerService
    {
        Product Details(int id);

        IEnumerable<Product> Search(string prodSearch);

        IEnumerable<Product> List(string prodCode);

        IEnumerable<Product> ListOfProducts();
    }
}
