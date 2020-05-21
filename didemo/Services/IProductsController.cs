using System;
using System.Collections.Generic;

namespace didemo.Services 
{
  public interface IProductsService
  {
      IEnumerable<Product> GetProducts();
  }
}
