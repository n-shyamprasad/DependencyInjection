using System;
using System.Collections.Generic;
using System.Linq;

namespace didemo.Services {
  public class ProductsServiceSQL: IProductsService 
  {
    private readonly List<Product> Products = new List<Product> 
    { 
      new Product { Title= "DVD player - From SQL data source" },
      new Product { Title= "TV  - From SQL data source" },
      new Product { Title= "Projector  - From SQL data source" }
    };

    public IEnumerable<Product> GetProducts() 
    {
      return Products.AsEnumerable();
    }
  }
}
