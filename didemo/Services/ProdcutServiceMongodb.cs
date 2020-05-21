using System;
using System.Collections.Generic;
using System.Linq;

namespace didemo.Services {
  public class ProductsServiceMongodb: IProductsService 
  {
    private readonly List<Product> Products = new List<Product> 
    { 
      new Product { Title= "DVD player - From Mongodb data source" },
      new Product { Title= "TV  - From Mongodb data source" },
      new Product { Title= "Projector  - From Mongodb data source" }
    };

    public IEnumerable<Product> GetProducts() 
    {
      return Products.AsEnumerable();
    }
  }
}
